using System;

public class Entity
{
    protected int entityId;
    protected Location location;
    protected EntityTypes type;

    public Entity(EntityTypes aType)
    {
        type = aType;
    }


    public Location GetLocation()
    {
        return location;
    }

    public void SetLocation(Location aLocation)
    {
        location = aLocation;
    }

    public void SetLocationY(Directions aDir)
    {
        if (aDir == Directions.RIGHT)
        {
            location.y++;
        }
        else
        {
            location.y--;
        }
    }

    public void SetLocationX(Directions aDir)
    {
        if (aDir == Directions.DOWN)
        {
            location.x++;
        }
        else
        {
            location.x--;
        }
 
    }

    public bool GetIsSolid()
    {
        if(type == EntityTypes.Wall || type == EntityTypes.MovableBlock)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public EntityTypes GetEntityType()
    {
        return type;
    }

    public void Move(Directions aDir, Entity targetEntity, Entity potentialPushToEntity)
    {

        if(aDir == Directions.UP || aDir == Directions.DOWN)
        {
            HandleYMovement(aDir, targetEntity, potentialPushToEntity);
        }
        if(aDir == Directions.LEFT || aDir == Directions.RIGHT)
        {
            HandleXMovement(aDir, targetEntity, potentialPushToEntity);
        }
    }

    public void Move(Directions aDir, Entity targetEntity)
    {

        if (aDir == Directions.UP || aDir == Directions.DOWN)
        {
            HandleYMovement(aDir, targetEntity);
        }
        if (aDir == Directions.LEFT || aDir == Directions.RIGHT)
        {
            HandleXMovement(aDir, targetEntity);
        }
    }

    private void HandleXMovement(Directions aDir, Entity targetEntity)
    {
        if (targetEntity.GetIsSolid() == false)
        {
            SetLocationX(aDir);
        }
        else
        {
            if (targetEntity.GetEntityType() == EntityTypes.MovableBlock)
            {
                SetLocationX(aDir);
                targetEntity.Move(aDir);
            }
            else
            {
                return;
            }
        }
    }

    private void HandleYMovement(Directions aDir, Entity targetEntity)
    {
        if (targetEntity.GetIsSolid() == false)
        {
            SetLocationX(aDir);
        }
        else
        {
            if (targetEntity.GetEntityType() == EntityTypes.MovableBlock)
            {
                SetLocationX(aDir);
                targetEntity.Move(aDir);
            }
            else
            {
                return;
            }
        }
    }

    public void Move(Directions aDir)
    {

        if (aDir == Directions.UP || aDir == Directions.DOWN)
        {
            HandleYMovement(aDir);
        }
        if (aDir == Directions.LEFT || aDir == Directions.RIGHT)
        {
            HandleXMovement(aDir);
        }
    }

    protected void HandleXMovement(Directions aDir, Entity targetEntity, Entity potentialPushToEntity)
    {
        if(targetEntity.GetIsSolid() == false){
            SetLocationX(aDir);
        }
        else
        {
            if(targetEntity.GetEntityType() == EntityTypes.MovableBlock)
            {
                SetLocationX(aDir);
                targetEntity.Move(aDir);
            }else{
                return;
            }
        }


    }

    protected void HandleYMovement(Directions aDir, Entity targetEntity, Entity potentialPushToEntity)
    {
        if(targetEntity.GetIsSolid() == false){
            SetLocationY(aDir);
        }
        else
        {
            if(targetEntity.GetEntityType() == EntityTypes.MovableBlock)
            {
                if(potentialPushToEntity.GetIsSolid())
                {
                    return;
                }
                else
                {
                    targetEntity.Move(aDir);
                    SetLocationY(aDir);
                }
                
            }else{
                return;
            }
        }
    }

    protected void HandleXMovement(Directions aDir)
    {
        SetLocationX(aDir);
    }

    protected void HandleYMovement(Directions aDir)
    {
        SetLocationY(aDir);
    }

}