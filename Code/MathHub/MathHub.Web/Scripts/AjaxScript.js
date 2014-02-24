function getCommentAjax(elementId, postId, offset) {
    var url = "/Problem/Comment/";
    $.post(url, { postId: postId, offset: offset }, function (data) {
        $("#" + elementId).html($("#" + elementId).html() + data);
    });
}

function getHintAjax(postId, offset) {
    var url = "/Problem/Hint/";
    $.post(url, { postId: postId, offset: offset }, function (data) {
        $("#problemHints").html(data);
    });
}

function getAnswerAjax(postId, offset) {
    var url = "/Problem/Answer/";
    $.post(url, { postId: postId, offset: offset }, function (data) {
        $("#problemAnswers").html(data);
    });
}

function postComment(formId, elementId, postId, offset) {
    var postData = jQuery("#commentform").serializeArray();
    var formURL = "Problem/AddComment";
    jQuery.ajax(
        {
            url: formURL,
            type: "POST",
            data: postData,
            success: function (data) {
                if (data) {
                    getCommentAjax(elementId, postId, offset);
                } else {

                }
            }, 
            error: function () {
                
            }
            
        });  
    return false;
}
