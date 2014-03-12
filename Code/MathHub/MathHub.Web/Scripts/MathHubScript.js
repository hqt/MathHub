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
    when click button. will get comments from server
    show textarea to post comment
    hide button "show comment/add comment"
    ref : view StackOverFlow for example
*/
function showCommentOnClick(showId, postId, formId, hideId) {
    getCommentAjax(showId, postId, -1);
    showElementById(formId);
    hideElementById(hideId);
}