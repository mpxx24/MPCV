import BaseView = require("./IBaseView");

interface IAssistantConfiguration {
    TalkBubbleId: string;
    AssistantId: string;
    InfoLinkId: string;
}

class Assistant implements BaseView.IBaseView{
    configuration: IAssistantConfiguration;
    textBubbleDiv: any;

    constructor(configuration: IAssistantConfiguration) {
        this.configuration = configuration;
        this.initializeView();
        this.initializeAssistant();
        this.initializeAssistantsActions();
    }

    initializeView() {
    };

    initializeAssistant(): void {
        this.textBubbleDiv = $(`#${this.configuration.TalkBubbleId} > p`);
    };

    initializeAssistantsActions(): void {
        this.sayLetterByLetter(`Hi, welcome at ${document.title} view. Do you need any help?`);
    };

    sayLetterByLetter(message: string): void {
        var letters = message.split("");
        var index = 0;
        this.textBubbleDiv.text("");

        var interval = setInterval(() => {
            if (this.textBubbleDiv.text().length < message.length) {
                this.setTextBubbleText(this.textBubbleDiv.text() + letters[index]);
                index++;
            } else {
                clearInterval(interval);
                this.showYesNoButtons();
                this.showAssistantInfoLink();
            }
        }, 40);
    };

    showYesNoButtons(): void {
        var yesButton = $(HtmlControlsHelper.HtmlButton("yes"));
        var noButton = $(HtmlControlsHelper.HtmlButton("no"));
        yesButton.on("click", () => { this.onYesHelpButtonClicked() });
        noButton.on("click", () => { this.onNoHelpButtonClicked() });

        $(`#${this.configuration.AssistantId}`).append(yesButton);
        $(`#${this.configuration.AssistantId}`).append(noButton);
    };

    setTextBubbleText(message: string): void {
        this.textBubbleDiv.text(message);
    };

    setQuestionsFlowForCurrentSite(): void {
    };

    getAnswerFromTheServer(): void {
    };

    customContextMenuActions(): void {
    };

    onYesHelpButtonClicked(): void {
        this.setTextBubbleText("");
        var ulWithOptions = HtmlControlsHelper.HtmlUl(2, ["option1", "option2"]);
        console.log(ulWithOptions);
        this.textBubbleDiv.append(ulWithOptions);
    };

    onNoHelpButtonClicked(): void {
        alert("NO WAS CLICKED");
    };

    showAssistanInfo() {
        alert("INFORMATIONS");
    };

    showAssistantInfoLink() {
        //$(`#${this.configuration.InfoLinkId}`).click(this.infoLinkClicked.bind(this));
        $(`#${this.configuration.InfoLinkId}`).show();
    };

    //infoLinkClicked(): void {};
}