"use strict";
/*jslint browser: true*/
/*global $, jQuery, alert*/

/* 
    @Author : Huynh Quang Thao
    edit 1 : add strict mode for javascript. Reference link : http://ejohn.org/blog/ecmascript-5-strict-mode-json-and-more/
    edit 2 : add comment option to by-pass jslint check

    @Author : Nguyen Ngoc Thanh Hai

    @Author : Dinh Quang Trung
*/

/*
    Explain             :   Get more comments and append to elementId
    parameters          :
        elementId       :   where to append content after loading
        postId          :   id of post.
        offset          :   number of items will load (0 : will be system default)
    return              :   partial view of list of CommentItem ViewModel
    original author     :   Nguyen Ngoc Thanh Hai
*/
function getCommentAjax(elementId, postId, offset) {
    var url = "/Problem/Comment/";
    $.post(url, { postId: postId, offset: offset }, function (data) {
        $("#" + elementId).html($("#" + elementId).html() + data);
    });
}

/*
    Explain             :   ajax loading hint list when first loading problem detail
    parameters          :
        elementId       :   where to append content after loading
        postId          :   id of question. use this id to know its hint or answer
        offset          :   number of items will load (0 : will be system default)
    return              :   partial view of list of HintItem ViewModel
    original author     :   Nguyen Ngoc Thanh Hai
*/
function getHintAjax(formId, postId, offset) {
    var url = "/Problem/Hint/";
    $.post(url, { postId: postId, offset: offset }, function (data) {
        $("#" + formId).html(data);
    });
}

/*
    Explain             :   ajax loading answer list when first loading problem detail
    parameters          :
        formId          :   where to append content after loading
        postId          :   id of question. use this id to know its hint or answer
        offset          :   number of items will load (0 : will be system default)
    return              :   partial view of list of AnswerItem ViewModel
    original author     :   Nguyen Ngoc Thanh Hai
*/
function getAnswerAjax(formId, postId, offset) {
    var url = "/Problem/Answer/";
    $.post(url, { postId: postId, offset: offset }, function (data) {
        $("#" + formId).html(data);
    });
}

/*
    Explain             :
    parameters          :
        formId          :   post form (include postId, content ... to send to server). 
                            after send success, reset again all field to empty
        commentDivId    :   location to append comment
    return              :   data return back is a partial view of comment view model
    original author     :   Nguyen Ngoc Thanh Hai
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
    Explain             :
    parameters          :
        formId          :   post form (include postId, content ... to send to server). 
                            after send success, reset again all field to empty
        answerDivId     :   location to append answer
    return              :   data return back is a partial view of answer view model
    original author     :   Nguyen Ngoc Thanh Hai
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
    Explain             :
    parameters          :
        formId          :   post form (include postId, content ... to send to server). 
                            after send success, reset again all field to empty
        hintDivId       :   location to append Hint
    return              :   data return back is a partial view of answer view model
    original author     :   Nguyen Ngoc Thanh Hai
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