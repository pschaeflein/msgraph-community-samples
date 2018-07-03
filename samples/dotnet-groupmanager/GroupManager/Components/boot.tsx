﻿// add an export line for each component. This forces webpack to pick them all up.
import 'office-ui-fabric-react/dist/css/fabric.css';
import { GroupList, Group, IGroupListState } from './GroupList';
import { GroupDetails } from './GroupDetails';
import { initializeIcons } from 'office-ui-fabric-react/lib/Icons';
initializeIcons(/* optional base url */);

// items actually used on _Layout partial
import * as React from 'react';
import * as ReactDOM from 'react-dom';
import { Banner, IBannerProps } from './banner';
import { NavMenu } from './NavMenu';
import { Selection } from 'office-ui-fabric-react/lib/Selection';

export function renderBanner(name: string, email: string, imageUrl: string) {
  ReactDOM.render(
    <Banner name={name} email={email} imageUrl={imageUrl} />,
    document.getElementById('react-banner')
  );
}

export function renderNavMenu() {
  ReactDOM.render(
    <NavMenu />,
    document.getElementById('react-navmenu')
  );
}

export function RenderGroupList() {
  ReactDOM.render(
    <GroupList></GroupList>,
    document.getElementById('react-groupList')
  );
}


// Allow Hot Module Replacement
if (module.hot) {
  module.hot.accept();
}
