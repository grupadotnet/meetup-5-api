import React from 'react';
import { deleteData } from '../lib';

const User = ({ id, name, email, onDeleted }) => {
  const remove = () => deleteData(`weatherforecast?id=${id}`).then(onDeleted);

  return (
    <>
      <div><span>Nazwa użytkownika: </span>{name} ({email}) <button onClick={remove}>Usuń</button></div>
    </>
  );
};

export default User;
