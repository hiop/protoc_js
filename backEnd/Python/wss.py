#!/usr/bin/env python

import asyncio
import websockets
import protobuf

import Message_pb2

@asyncio.coroutine
def hello(websocket, path):
	while True:
		name = yield from websocket.recv()
		print("recv() {}".format(name))
		message = Message_pb2.Msg()
		message.ParseFromString(name)
		print("id {}".format(message.id))
		print("time_s {}".format(message.time_s))
		print("message {}".format(message.message))
		print("author {}".format(message.author))
		greeting = "Hello {}!".format(name)
		yield from websocket.send(greeting)
		#print("> {}".format(greeting))

start_server = websockets.serve(hello, '127.0.0.1', 8181)

asyncio.get_event_loop().run_until_complete(start_server)
asyncio.get_event_loop().run_forever()
