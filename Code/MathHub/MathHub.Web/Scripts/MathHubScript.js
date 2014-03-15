/// <reference path="../Views/Problem/Partials/_CommentPostForm.cshtml" />
/// <reference path="../Views/Problem/Partials/_CommentPostForm.cshtml" />
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
function showElementById(id) {
    $("#" + id).show();
}

function hideElementById(id) {
    $("#" + id).hide();
}

function showAndHideElementsById(showId, hideId) {
    $("#" + showId).show();
    $("#" + hideId).hide();
}

function getValueById(id) {
    return $("#" + id).val();
}

/*
    Explain             :    when click button. will get comments from server
                                                show textarea to post comment
                                                hide button "show comment/add comment"
                                                ref : view StackOverFlow for example
    parameters          :
        commentListId   :   where to append content after loading
        postId          :   id of question. use this id to know how to load all comments relate
        formId          :   form will be show (comment post form)
        hideId          :   element to be hide (show comment / add comment button)
    return              :   void
    original author     :   Nguyen Ngoc Thanh Hai
*/
function showCommentOnClick(commentListId, postId, formId, hideId) {
    getQuestionComments(commentListId, postId, -1);
    showElementById(formId);
    hideElementById(hideId);
}

/*
    Explain             :    when click button. will get comments from server. and append those comments to commentListId
                                                append textarea to post comment after commentListId
                                                hide button "show comment/add comment"
                                                ref : view StackOverFlow for example
    parameters          :
        commentListId   :   where to append content after loading
        postId          :   id of question. use this id to know how to load all comments relate
        formId          :   form will be show (comment post form)
        hideId          :   element to be hide (show comment / add comment button)
    return              :   void
    original author     :   Huynh Quang Thao
*/
function showReplyCommentsOnClick(commentListId, postId, formId, hideId) {
    // get and append reply comment
    getReplyComments(commentListId, postId, -1);

    // append form
    // $("#" + commentListId).after("<p>Test</p>");

    // temporary remove
    // showElementById(formId);

    hideElementById(hideId);
}