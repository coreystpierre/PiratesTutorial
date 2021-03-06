﻿using Improbable;
using Improbable.Collections;
using UnityEngine;

namespace Assets.Gamelogic.Pirates.Cannons
{
    public class DestroyCannonball : MonoBehaviour
    {
        public float SecondsUntilDestroy = 4f;
		public Option<EntityId> firerEntityId = new Option<EntityId>();
        private float spawnTime;

        void Start()
        {
            spawnTime = Time.time;
        }

        void Update()
        {
            var lifeTime = Time.time - spawnTime;
            if (lifeTime > SecondsUntilDestroy)
            {
                Destroy(gameObject);
            }
        }
    }
}