"use strict";
var AddPost = (function () {
    function AddPost(config) {
        this.configuration = config;
        this.initializeView();
        this.initializeControls();
    }
    AddPost.prototype.initializeView = function () {
    };
    ;
    AddPost.prototype.initializeControls = function () {
        $("#" + this.configuration.AddPostButtonId).click(this.addNewPost.bind(this));
    };
    ;
    AddPost.prototype.addNewPost = function () {
        var input = {
            Title: $("#" + this.configuration.TitleTextBoxId).val(),
            Description: $("#" + this.configuration.ShortDescriptionTextAreaId).val(),
            Text: $("#" + this.configuration.TextTextAreaId).val()
        };
        $.ajax({
            url: this.configuration.AddPostActionAddress,
            type: "POST",
            dataType: "text",
            data: { p: JSON.stringify(input) },
            complete: function () {
                alert("ADDED NEW POST");
            },
            error: function (error) {
                alert("Failed to add new post");
            }
        });
    };
    ;
    return AddPost;
}());
//# sourceMappingURL=AddPost.js.map