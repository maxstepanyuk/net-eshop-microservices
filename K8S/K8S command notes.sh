# check
kubectl version --short

#list
kubectl get deployments
kubectl get pods

# (stop and) delete 
kubectl delete deployment platforms-depl

# deploy
kubectl apply -f platfoms-depl.yaml #deploy platformservice
kubectl apply -f platforms-np-srv.yaml #deploy NodePort for platformservice
