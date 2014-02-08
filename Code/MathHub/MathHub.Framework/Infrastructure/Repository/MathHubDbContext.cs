using MathHub.Core.Infrastructure.Repository;
using MathHub.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHub.Framework.Infrastructure.Repository
{
    /// <summary>
    /// Use same DBContext for whole one request (by combine with DI Container)
    /// about Dispose pattern. Reference :
    ///     http://msdn.microsoft.com/en-us/library/system.idisposable(v=vs.110).aspx
    ///     http://www.codeproject.com/Articles/413887/Understanding-and-Implementing-IDisposable-Interfa
    /// </summary>
    public class MathHubDbContext : IMathHubDbContext, IDisposable
    {
        // context to our currently database
        // this is managed resource, that should clean in Dispose method
        MathHubModelContainer ctx;

        // Track whether Dispose has been called. 
        private bool disposed = false;

        public MathHubDbContext()
        {
            ctx = new MathHubModelContainer();
            // config option for DBContext
            ctx.Configuration.LazyLoadingEnabled = false;
            ctx.Configuration.ProxyCreationEnabled = false;

            // ctx.Configuration.LazyLoadingEnabled = true;
            // ctx.Configuration.ProxyCreationEnabled = true;
            // ctx.Configuration.AutoDetectChangesEnabled = true;

            Console.WriteLine("Create new DBContext");

        }

        /// <summary>
        /// Other Service will get context from this
        /// </summary>
        /// <returns></returns>
        public MathHubModelContainer GetDbContext()
        {
            if (!disposed) return ctx;
            else return null;
        }


        /// <summary>
        ///  Implement IDisposable. 
        ///  Do not make this method virtual. 
        ///  A derived class should not be able to override this method. 
        /// </summary>
        public void Dispose()
        {
            // If this function is being called the user wants to release the
            // resources. (by using try-catch-finally or using block)
            // lets call the Dispose which will do this for us.
            Dispose(true);

            // This object will be cleaned up by the Dispose method. 
            // Therefore, you should call GC.SupressFinalize to 
            // take this object off the finalization queue 
            // and prevent finalization code for this object 
            // from executing a second time for performance
            GC.SuppressFinalize(this);
        }

        // Dispose(bool disposing) executes in two distinct scenarios. 
        // If disposing equals true, the method has been called directly 
        // or indirectly by a user's code. Managed and unmanaged resources 
        // can be disposed. 
        // If disposing equals false, the method has been called by the 
        // runtime from inside the finalizer and you should not reference 
        // other objects. Only unmanaged resources can be disposed. 
        protected virtual void Dispose(bool disposing)
        {
            // Check to see if Dispose has already been called. 
            if (!this.disposed)
            {
                if (disposing == true)
                {
                    //someone want the deterministic release of all resources
                    //Let us release all the managed resources
                    ReleaseManagedResources();
                }
                else
                {
                    // Do nothing, no one asked a dispose, the object went out of
                    // scope and finalized is called so lets next round of GC 
                    // release these resources
                }

                // Release the unmanaged resource in any case as they will not be released by GC
                // both when disposing true or false
                ReleaseUnmangedResources();

                // Note disposing has been done.
                disposed = true;
            }
        }

        protected virtual void ReleaseManagedResources()
        {
            if (ctx != null)
            {
                // save all data first
                ctx.SaveChanges();
                // clear resource
                ctx.Dispose();
            }
        }

        protected virtual void ReleaseUnmangedResources()
        {
            // currently. Do nothing. because our class doesn't have unamanaged resource
        }

        // Use C# destructor syntax for finalization code. 
        // This destructor will run only if the Dispose method does not get called. 
        // It gives your base class the opportunity to finalize. 
        // Do not provide destructors in types derived from this class.
        ~MathHubDbContext()
        {
            // The object went out of scope and finalized is called
            // Lets call dispose in to release unmanaged resources 
            // the managed resources will anyways be released when GC 
            // runs the next time.
            // Do not re-create Dispose clean-up code here. 
            // Calling Dispose(false) is optimal in terms of 
            // readability and maintainability.
            Dispose(false);
        }
    }
}
