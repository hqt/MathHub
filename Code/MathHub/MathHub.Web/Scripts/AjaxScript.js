/*
    Get more comments.
    and append to currently elementId
*/
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

/*
    parameters          :
        formId          :   post form (include postId, content ... to send to server). 
                            after send success, reset again all field to empty
        commentDivId    :   location to append comment
    return              :   data return back is a partial view of comment view model
*/
function postComment(formId, commentDivId) {
    var postData = jQuery("#" + formId).serializeArray();
    var formURL = "/Problem/AddComment";
    $.ajax(
        {
            url: formURL,
            type: "POST",
            data: postData,
            success: function (data) {
                if (data) {
                    //$("#" + commentDivId).append(postData[0].value + "<br/>");
                    $("#" + commentDivId).append(data + "<br/>");
                    $("#" + formId).children("textarea").val("");                
                } else {

                }
            }, 
            error: function () {
                
            }
            
        });  
    return false;
}

/*
    parameters          :
        formId          :   post form (include postId, content ... to send to server). 
                            after send success, reset again all field to empty
        answerDivId     :   location to append answer
    return              :   data return back is a partial view of answer view model
*/
function postAnswer(formId, answerDivId) {
    var postData = jQuery("#" + formId).serializeArray();
    var formURL = "/Problem/AddAnswer";
    $.ajax(
        {
            url: formURL,
            type: "POST",
            data: postData,
            success: function (data) {
                if (data) {
                    // $("#" + answerDivId).append(postData[0].value + "<br/>");
                    $("#" + answerDivId).append(data + "<br/>");
                    $("#" + formId).children("textarea").val("");
                } else {

                }
            },
            error: function () {

            }

        });
    return false;
}

/*
    parameters          :
        formId          :   post form (include postId, content ... to send to server). 
                            after send success, reset again all field to empty
        hintDivId       :   location to append Hint
    return              :   data return back is a partial view of answer view model
*/
function postHint(formId, hintDivId) {
    var postData = jQuery("#" + formId).serializeArray();
    var formURL = "/Problem/AddHint";
    $.ajax(
        {
            url: formURL,
            type: "POST",
            data: postData,
            success: function (data) {
                if (data) {
                    // $("#" + hintDivId).append(postData[0].value + "<br/>");
                    $("#" + hintDivId).append(data + "<br/>");
                    $("#" + formId).children("textarea").val("");
                } else {

                }
            },
            error: function () {

            }

        });
    return false;
}