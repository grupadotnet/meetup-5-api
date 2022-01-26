import React, { useEffect, useState } from 'react';
import { getData } from '../lib';
import User from './User';

const FetchUsers = () => {
  const [users, setUsers] = useState([]);

  const fetch = () => getData('weatherforecast', { method: "GET" }).then(setUsers);

  useEffect(() => fetch(), []);

  return (
    <>
      <h1>Users</h1>
      {users.map(user => (
        <User key={user.id} {...user} onDeleted={fetch} />
      ))}
    </>
  );
};

export default FetchUsers;
