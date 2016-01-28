import * as React from 'react';
import * as ReactDom from 'react-dom';
import { Version } from '@microsoft/sp-core-library';
import { BaseClientSideWebPart } from '@microsoft/sp-webpart-base';

import * as strings from 'MyApplicationWebPartStrings';
import MailForm from './components/MailForm';
import { IMailFormProps } from './components/IMailFormProps';

export interface IMyApplicationWebPartProps {
}

export default class MyApplicationWebPart extends BaseClientSideWebPart<IMyApplicationWebPartProps> {

  public render(): void {
    const element: React.ReactElement<IMailFormProps> = React.createElement(
      MailForm,
      {
        context: this.context,
      }
    );

    ReactDom.render(element, this.domElement);
  }

  protected onDispose(): void {
    ReactDom.unmountComponentAtNode(this.domElement);
  }

  protected get dataVersion(): Version {
    return Version.parse('1.0');
  }

}
