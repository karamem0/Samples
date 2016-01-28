declare interface IMyApplicationWebPartStrings {
    PropertyPaneDescription: string;
    BasicGroupName: string;
    DescriptionFieldLabel: string;
}

declare module 'MyApplicationWebPartStrings' {
    const strings: IMyApplicationWebPartStrings;
    export = strings;
}
