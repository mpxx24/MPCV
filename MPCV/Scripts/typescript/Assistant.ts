interface IAssistantConfiguration {
    TalkBubbleId: string;
    AssistantId: string;
}

class Assistant {
    configuration: IAssistantConfiguration;
    textBubbleDiv: any;

    constructor(configuration: IAssistantConfiguration) {
        this.configuration = configuration;
        this.initializeAssistant();
        this.initializeAssistantsActions();
    }

    initializeAssistant(): void {
        this.textBubbleDiv = $(`#${this.configuration.TalkBubbleId}`);
    };

    initializeAssistantsActions(): void {
        this.sayLetterByLetter(`Hi, welcome at ${document.title} view. Do you need any help?`);
        var yesButton = $('<input type="button" value="Yes"/>');
        var noButton = $('<input type="button" value="No"/>');
        yesButton.on("click", () => { this.onYesHelpButtonClicked() });
        noButton.on("click", () => { this.onNoHelpButtonClicked() });

        $(`#${this.configuration.AssistantId}`).append(yesButton);
        $(`#${this.configuration.AssistantId}`).append(noButton);
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
            }
        }, 50);
    }

    setTextBubbleText(message: string) {
        this.textBubbleDiv.text(message);
    }

    setQuestionsFlowForCurrentSite(): void {
    };

    getAnswerFromTheServer(): void {
    };

    customContextMenuActions(): void {
    };

    onYesHelpButtonClicked(): void {
        alert("YES WAS CLICKED");
    }

    onNoHelpButtonClicked(): void {
        alert("NO WAS CLICKED");
    }
}