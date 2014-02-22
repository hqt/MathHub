function showElementById(id) {
    $("#" + id).show();
}

function hideElementById(id) {
    $("#" + id).hide();
}

function showCommentOnClick(showId, postId, formId) {
    getCommentAjax(showId, postId);
    showElementById(formId);
}