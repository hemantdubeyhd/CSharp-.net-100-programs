﻿// See https://aka.ms/new-console-template for more information
using BankAccounts;

AccountHolder holder = AccountHolder.Create();

AccountBalance balance = new AccountBalance();
balance.Deposit();
balance.Withdrawal();

AccountDetail detail = AccountDetail.Create(holder, balance);

detail.DisplayInfo();
