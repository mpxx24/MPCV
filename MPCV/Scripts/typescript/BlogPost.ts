import BaseView = require("./IBaseView");

interface IBlogPost {
    PostId: number,
    VisitorNameTextBoxId: string;
    CommentTextAreaId: string;
    AddCommentButton: string;
    AddCommentAddress: string;
}

class BlogPost implements BaseView.IBaseView{
    configuration: IBlogPost;

    constructor(configuration: IBlogPost) {
        this.configuration = configuration;
        this.initializeView();
        this.initializeControls();
    }

    initializeView(): void {
    };
    
    initializeControls(): void {
        $(`#${this.configuration.AddCommentButton}`).click(this.saveComment.bind(this));
    };

    saveComment(): void {
        var nick = $(`#${this.configuration.VisitorNameTextBoxId}`).val();
        var comment = $(`#${this.configuration.CommentTextAreaId}`).val();

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
            complete() {
                location.reload();
            }
        });
    }
}