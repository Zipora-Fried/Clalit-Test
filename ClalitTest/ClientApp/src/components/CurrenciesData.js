import React, { useState, useEffect } from 'react';
import { Currency } from './Currency';

export default function CurrenciesData() {
  const [currencies, setCurrencies] = useState([]);

  const fetchCurrencyData = () => {
    fetch("currency")
      .then((res) => res.json())
      .then((res) => {setCurrencies(res)
    });
  }

  useEffect(() => {
    fetchCurrencyData()
  }, []);

  return (
    <div className="currencies-wrapper">
      <h1 id="tabelLabel" >Currencies</h1>
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Name</th>
            <th>Unit</th>
            <th>Currency code</th>
            <th>Country</th>
            <th>Rate</th>
            <th>Change</th>
          </tr>
        </thead>
        <tbody>
          {currencies.map(currency => <Currency currency={currency} />)}
        </tbody>
      </table>
    </div>
  )
};