﻿function getCommentAjax(elementId, postId, offset) {
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

function postComment(formId, postId, commentDivId) {
    var postData = jQuery("#commentPostForm").serializeArray();
    var formURL = "/Problem/AddComment";
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


function postAnswer(formId, postId, answerDivId) {
    var postData = jQuery("#answerPostForm").serializeArray();
    var formURL = "/Problem/AddAnswer";
    $.ajax(
        {
            url: formURL,
            type: "POST",
            data: postData,
            success: function (data) {
                if (data) {
                    $("#" + answerDivId).append(postData[0].value + "<br/>");
                    $("#" + formId).children("textarea").val("");
                } else {

                }
            },
            error: function () {

            }

        });
    return false;
}

function postHint(formId, postId, hintDivId) {
    var postData = jQuery("#hintPostForm").serializeArray();
    var formURL = "/Problem/AddHint";
    $.ajax(
        {
            url: formURL,
            type: "POST",
            data: postData,
            success: function (data) {
                if (data) {
                    $("#" + hintDivId).append(postData[0].value + "<br/>");
                    $("#" + formId).children("textarea").val("");
                } else {

                }
            },
            error: function () {

            }

        });
    return false;
}