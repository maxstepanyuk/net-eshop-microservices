# check
kubectl version --short

#list
kubectl get deployments
kubectl get pods
kubectl get services

# (stop and) delete 
kubectl delete deployment platforms-depl
kubectl delete deployment platforms-np-srv

# deploy
kubectl apply -f platforms-depl.yaml #deploy platformservice
kubectl apply -f platforms-np-srv.yaml #deploy NodePort for platformservice
