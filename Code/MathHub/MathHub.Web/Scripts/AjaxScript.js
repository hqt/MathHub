function getComment(postId, offset, limit) {
    var url = "/Comment/Index/";
    $.get(url, { Id: postId, Offset: offset }, function(data) {
        $("#problemComments").html(data);
    });
}