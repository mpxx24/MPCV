"use strict";
var Blog = (function () {
    function Blog(config) {
        this.configuration = config;
        this.initializeView();
        this.initializeControls();
    }
    Blog.prototype.initializeView = function () {
    };
    ;
    Blog.prototype.initializeControls = function () {
        $("#" + this.configuration.AddPostButton).click(this.goToAddNewPostView.bind(this));
    };
    ;
    Blog.prototype.goToAddNewPostView = function () {
    };
    ;
    return Blog;
}());
