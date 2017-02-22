import BaseView = require("./IBaseView");

interface IAddPost {
    TitleTextBoxId: string;
    ShortDescriptionTextAreaId: string;
    TextTextAreaId: string;
    AddPostButtonId: string;
    AddPostActionAddress: string;
}

class AddPost implements BaseView.IBaseView {
    configuration: IAddPost;

    constructor(config: IAddPost) {
        this.configuration = config;
        this.initializeView();
        this.initializeControls();
    }

    initializeView(): void {
    };

    initializeControls(): void {
        $(`#${this.configuration.AddPostButtonId}`).click(this.addNewPost.bind(this));
    };

    addNewPost(): void {
        var input = {
            Title: $(`#${this.configuration.TitleTextBoxId}`).val(),
            Description: $(`#${this.configuration.ShortDescriptionTextAreaId}`).val(),
            Text: $(`#${this.configuration.TextTextAreaId}`).val()
        }

        $.ajax({
            url: this.configuration.AddPostActionAddress,
            type: "POST",
            dataType: "text",
            data: { p: JSON.stringify(input) },
            complete() {
                alert("ADDED NEW POST");
            },
            error(error) {
                alert("Failed to add new post");
            }
        });
    };
}