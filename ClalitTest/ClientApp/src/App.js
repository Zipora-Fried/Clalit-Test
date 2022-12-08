import React, { Component } from 'react';
import CurrenciesData from './components/CurrenciesData';
import './custom.css';

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <div>
          <CurrenciesData />
      </div>
    );
  }
}
