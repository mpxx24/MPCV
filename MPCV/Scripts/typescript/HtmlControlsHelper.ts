class HtmlControlsHelper {
    static HtmlButton(buttonText: string): string {
        return `<input type="button" value="${buttonText}"/>`;
    }    

    static HtmlUl(numberOfLiElements: number, names: Array<string>): string {
        var ulBeginning = "<ul>";

        if (numberOfLiElements !== names.length) {
            return "";
        }

        for (let i = 0; i < numberOfLiElements; i++) {
            ulBeginning += `<li>${names[i]}</li>`;
        }
        ulBeginning += "</ul>";

        return ulBeginning;
    }
}