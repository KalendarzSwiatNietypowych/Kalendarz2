const path = "https://localhost:7106/";
const signalR = require("@microsoft/signalr");

export const connection = new signalR.HubConnectionBuilder()
  .withUrl(path + "fetchConversationHub")
  .build();

const start = async () => {
  try {
    await connection.start();
  } catch (err) {
    setTimeout(start, 5000);
  }
};

connection.onclose(async () => {
  await start();
});

start();