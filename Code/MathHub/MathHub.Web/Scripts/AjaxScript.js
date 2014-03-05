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

function postComment(formId, elementId, postId, commentDivId) {
    var postData = jQuery("#commentPostForm").serializeArray();
    var formURL = "http://localhost:8102/Problem/AddComment";
    $.ajax(
        {
            url: formURL,
            type: "POST",
            data: postData,
            success: function (data) {
                if (data) {
                    $("#" + commentDivId).append(postData[0].value + "<br/>");
                    $("#" + formId).children("textarea").val("");                
                } else {

                }
            }, 
            error: function () {
                
            }
            
        });  
    return false;
}
