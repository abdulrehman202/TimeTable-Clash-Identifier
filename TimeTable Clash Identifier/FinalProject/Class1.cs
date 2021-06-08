#include <iostream>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <arpa/inet.h>
#include <stdlib.h>
#include <linux/socket.h>
#include <unistd.h>
using namespace std;

int main()

{

struct in_addr addr;
char msg[100];
int conn_sock,comm_sock,n,c=0;
struct sockaddr_in server_addr,client_addr;
conn_sock=socket(AF_INET,SOCK_STREAM,0);

server_addr.sin_family=AF_INET;
server_addr.sin_port=1234;
server_addr.sin_addr.s_addr=inet_addr("127.0.0.1");

bind(conn_sock,(struct sockaddr *)&server_addr,sizeof(server_addr));

listen(conn_sock,10);

while(1){

comm_sock=accept(conn_sock, (struct sockaddr *) &client_addr, (socklen_t *) &client_addr);

pid_t pid = fork();

if(pid == 0){
c=0;

while(c<5){
cout<<"\n\nConnected with client!";

n = read(comm_sock,msg,100);

cout<<"\n\nReceived data from client is: \n"<<msg<<endl;

n = send(comm_sock,"OK",100);
c++;
close(comm_sock);
}

}

else
{
close(comm_sock);
}

}
//close(comm_sock);
//close(conn_sock);

return 0;
}
