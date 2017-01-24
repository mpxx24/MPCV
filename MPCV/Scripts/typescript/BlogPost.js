"use strict";
var BlogPost = (function () {
    function BlogPost(configuration) {
        this.configuration = configuration;
        this.initializeView();
        this.initializeControls();
    }
    BlogPost.prototype.initializeView = function () {
    };
    ;
    BlogPost.prototype.initializeControls = function () {
        $("#" + this.configuration.AddCommentButton).click(this.saveComment.bind(this));
    };
    ;
    BlogPost.prototype.saveComment = function () {
        var nick = $("#" + this.configuration.VisitorNameTextBoxId).val();
        var comment = $("#" + this.configuration.CommentTextAreaId).val();
        var content = {
            Id: this.configuration.PostId,
            Name: nick,
            Comment: comment
        };
        $.ajax({
            url: this.configuration.AddCommentAddress,
            type: "POST",
            dataType: "json",
            data: { p: JSON.stringify(content) },
            complete: function () {
                location.reload();
            }
        });
    };
    return BlogPost;
}());
//# sourceMappingURL=BlogPost.js.map