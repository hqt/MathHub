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

function showCommentOnClick(showId, postId, formId, hideId) {
    getCommentAjax(showId, postId, -1);
    showElementById(formId);
    hideElementById(hideId);
}