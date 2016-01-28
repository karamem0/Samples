import * as React from 'react';
import { create } from 'react-test-renderer';
import MyApplication from './MyApplication';
import { IMyApplicationProps } from './IMyApplicationProps';

// とりあえず必ず PASS するテスト
it('test1', () => {
  expect(true).toBe(true);
});

// スナップショットを作成するテスト
it('test2', () => {
  const props = {} as IMyApplicationProps;
  const tree = create(<MyApplication {...props} />).toJSON();
  expect(tree).toMatchSnapshot();
});
