﻿using System;
using System.Collections.Generic;
using UnityEngine;
using ResourcesPickups = SRResources.Game.Building.Pickups;
using System.Linq;

public class Level : MonoBehaviour
{
    public Level Initialize(Block[,] blockLayout)
    {
        this.blockLayout = blockLayout;
        int index = 0;
        Dictionary<TypeSafe.PrefabResource, int> pickups = GetPickups();
        this.blocks = GetComponentsInChildren<Block>().Select(block =>
        {
            block.Initialize(index, (id) => OnBlockDestroyed(id));
            TypeSafe.PrefabResource choosen = Utils.RandomWeightedChooser(pickups);
            if (choosen.Name != "EmptyPickup")
            {
                GameObject pickUp = choosen.Instantiate();
                block.SetItemOnHit(pickUp);
                this.pickUps.Add(pickUp);
            }
            index++;
            return block.gameObject;
        }).ToArray();
        return this;
    }

    public Level SetLevelCleared(Action onLevelCleared)
    {
        this.onLevelCleared = onLevelCleared;
        return this;
    }

    public Level EnableIgnoreCollisionResult()
    {
        this.blocks.ToList().ForEach(block => {
            block.GetComponent<Block>().EnableIgnoreCollisionResult();
        });
        return this;
    }

    public Level DestroyPickUps()
    {
        this.pickUps.ForEach(pickUp =>
        {
            // if pickup consumed do not try to destroy it
            if (pickUp == null)
            {
                return;
            }
            Destroy(pickUp);
            return;
        });
        return this;
    }

    public Level Destroy()
    {
        Destroy(this.gameObject);
        return this;
    }

    private Level OnBlockDestroyed(int blockId)
    {
        int index = 0;
        bool finished = Array.TrueForAll(this.blocks, block => {
            bool isNotActive = !block.activeInHierarchy || blockId == index;
            index++;
            return isNotActive;
        });
        if (!finished)
        {
            return this;
        }
        this.onLevelCleared();
        return this;
    }

    private Dictionary<TypeSafe.PrefabResource, int> GetPickups()
    {
        Dictionary<TypeSafe.PrefabResource, int> pickups = new Dictionary<TypeSafe.PrefabResource, int>();
        pickups.Add(ResourcesPickups.heart, 3);
        pickups.Add(ResourcesPickups.clock, 3);
        pickups.Add(ResourcesPickups.star, 3);
        pickups.Add(ResourcesPickups.EmptyPickup, 91);
        return pickups;
    }

    private GameObject[] blocks;
    private Block[,] blockLayout;
    private List<GameObject> pickUps = new List<GameObject>();
    private Action onLevelCleared;
}
