import * as React from 'react';
import { Nav, INavProps, INavStyleProps } from 'office-ui-fabric-react/lib/Nav';

export class NavMenu extends React.Component<{}, {}> {
  constructor(props: INavProps, styleProps: INavStyleProps) {
    super(props, styleProps);
  }
   
  public render() {
    return (
      <Nav
        groups={[{
          links: [
            { name: 'Home', key: 'Home', url: '/' },
            { name: 'Groups', key: 'Groups', url: '/Groups' },
            { name: 'Policy', key: 'Policy', url: '/Policy' }
          ]
        }]}
      />
    );
  }
}
