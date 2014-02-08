using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Metadata.Edm;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Framework.Utils
{
    /// <summary>
    /// Extension to process on Attribute of Object Using Reflection API
    /// Will be use to proces on Entity Object
    /// </summary>
    public static class ReflectionUtils
    {
        
        public static PropertyInfo FindProperty(LambdaExpression lambdaExpression)
        {
            Expression expressionToCheck = lambdaExpression;

            bool done = false;

            while (!done)
            {
                switch (expressionToCheck.NodeType)
                {
                    case ExpressionType.Convert:
                        expressionToCheck = ((UnaryExpression)expressionToCheck).Operand;
                        break;
                    case ExpressionType.Lambda:
                        expressionToCheck = lambdaExpression.Body;
                        break;
                    case ExpressionType.MemberAccess:
                        var propertyInfo = ((MemberExpression)expressionToCheck).Member as PropertyInfo;
                        return propertyInfo;
                    default:
                        done = true;
                        break;
                }
            }

            return null;
        }

        public static bool HasCustomAttribute<T>(this ICustomAttributeProvider member) where T : Attribute
        {
            return member.GetCustomAttributes(typeof(T), false).Length == 1;
        }

        public static T GetCustomAttribute<T>(this ICustomAttributeProvider member) where T : Attribute
        {
            return member.GetCustomAttributes(typeof(T), false).Cast<T>().FirstOrDefault();
        }

        public static T GetCustomAttribute<T>(this ICustomAttributeProvider member, bool inherit) where T : Attribute
        {
            return member.GetCustomAttributes(typeof(T), inherit).Cast<T>().FirstOrDefault();
        }

        public static bool HasCustomAttribute<T>(this Type type)
        {
            return type.HasCustomAttribute(typeof(T));
        }

        public static bool HasCustomAttribute(this Type type, Type attributeType)
        {
            return TypeDescriptor.GetAttributes(type)[attributeType] != null;
        }

        public static object GetPropertyValue(this object obj, string property)
        {
            return TypeDescriptor.GetProperties(obj)[property].GetValue(obj);
        }

        public static IDictionary<string, object> ToDictionary(this object obj)
        {
            IDictionary<string, object> result = new Dictionary<string, object>();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(obj);
            foreach (PropertyDescriptor property in properties)
            {
                result.Add(property.Name, property.GetValue(obj));
            }
            return result;
        }

        /// <summary>
        /// Automatically find Key Property. Often not so stable
        /// </summary>
        /// <param name="type"></param>
        /// <returns>ProperyInfo of that type</returns>
        public static PropertyInfo GetKeyPropertyInfo(Type type)
        {
            var properties = type.GetProperties();
            foreach (var propertyInfo in properties)
            {
                var attributes = propertyInfo.GetCustomAttributes(true);
                if (attributes.Any(attribute => attribute is EdmScalarPropertyAttribute 
                    && ((EdmScalarPropertyAttribute)attribute).EntityKeyProperty))
                {
                    return propertyInfo;
                }
            }
            throw new ApplicationException(String.Format("No key property found for type {0}", type.Name));
        }

        /// <summary>
        /// Get directly Id Field of object. 
        /// Carefully to use this, because not all object has field Id. 
        /// But this method will work stable, if exist. and suitable for Mathhub Project :)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static PropertyInfo GetProperyNameId(Type type)
        {
            return type.GetProperty("Id");
        }

        /// <summary>
        /// Create expression for .Where(entity => entity.Id == 'id')
        /// </summary>
        /// <typeparam name="T">Type of entity</typeparam>
        /// <param name="id">Entity ID</param>
        /// <returns></returns>
        public static Expression<Func<T, bool>> GetExpressionFindId<T>(object id)
        {
            /* Get Primary key solution 1 */
            // Find primary key property based on primary key attribute.
            //var keyProperty = typeof(T).GetProperties().
            //    First(
            //        one =>
            //        one.GetCustomAttributes(typeof(EdmScalarPropertyAttribute), true)
            //        .Any(two => ((EdmScalarPropertyAttribute)two).EntityKeyProperty));

            /* Get Primary key solution 2 */            
            //var keyProperty = GetKeyPropertyInfo(typeof(T));

            /* Get Primary key solution 3 */
            var keyProperty = GetProperyNameId(typeof(T));

            // Create entity => portion of lambda expression
            ParameterExpression parameter = Expression.Parameter(typeof(T), "entity");

            // create entity.Id portion of lambda expression
            MemberExpression property = Expression.Property(parameter, keyProperty.Name);

            // create 'id' portion of lambda expression
            var equalsTo = Expression.Constant(id);

            // create entity.Id == 'id' portion of lambda expression
            var equality = Expression.Equal(property, equalsTo);

            // finally create entire expression - entity => entity.Id == 'id'
            Expression<Func<T, bool>> retVal =
                Expression.Lambda<Func<T, bool>>(equality, new[] { parameter });
            return retVal;
        }

    }
}
