import React from 'react';

export function Currency({currency}) {
  return (
    <tr key={currency.currencyCode}>
        <td>{currency.name}</td>
        <td>{currency.unit}</td>
        <td>{currency.currencyCode}</td>
        <td>{currency.country}</td>
        <td>{currency.rate}</td>
        <td>{currency.change}</td>
    </tr>
  );
}