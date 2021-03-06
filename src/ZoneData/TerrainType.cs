﻿
namespace ModernMUD
{
    /// <summary>
    /// Terrain types.  Used for the sector type of a room.
    /// </summary>
    public enum TerrainType
    {
        /// <summary>
        /// Indoors.
        /// </summary>
        inside = 0,
        /// <summary>
        /// City/civilized, outdoors.
        /// </summary>
        city,
        /// <summary>
        /// Field or grassland.
        /// </summary>
        field,
        /// <summary>
        /// Trees.
        /// </summary>
        forest,
        /// <summary>
        /// Hills and valleys.
        /// </summary>
        hills,
        /// <summary>
        /// Steep mountains.
        /// </summary>
        mountain, // 5
        /// <summary>
        /// Hot, dry desert.
        /// </summary>
        desert,
        /// <summary>
        /// Cold and icy.
        /// </summary>
        arctic,
        /// <summary>
        /// Soggy and mucky.
        /// </summary>
        swamp,
        /// <summary>
        /// Road, paved or dirt.
        /// </summary>
        road,
        /// <summary>
        /// Molten rock.
        /// </summary>
        lava, // 10
        /// <summary>
        /// Solid ice.
        /// </summary>
        glacier,
        /// <summary>
        /// Cold.
        /// </summary>
        tundra,
        /// <summary>
        /// Hot, wet, and full of trees
        /// </summary>
        jungle,
        /// <summary>
        /// Shallow and calm water.
        /// </summary>
        swimmable_water,
        /// <summary>
        /// Rough seas.
        /// </summary>
        unswimmable_water, // 15
        /// <summary>
        /// Ocean, unswimmable water.
        /// </summary>
        ocean,
        /// <summary>
        /// Underwater, but no sea floor.
        /// </summary>
        underwater_no_ground,
        /// <summary>
        /// Underwater, with sea floor.
        /// </summary>
        underwater_has_ground,
        /// <summary>
        /// Midair.
        /// </summary>
        air,
        /// <summary>
        /// Underground wilderness.
        /// </summary>
        underground_wild, // 20
        /// <summary>
        /// Urban underground.
        /// </summary>
        underground_city,
        /// <summary>
        /// Underground, enclosed space.
        /// </summary>
        underground_indoors,
        /// <summary>
        /// Underground, in swimmable water.
        /// </summary>
        underground_swimmable_water,
        /// <summary>
        /// Underground, impassable water.
        /// </summary>
        underground_unswimmable_water,
        /// <summary>
        /// Underground, in midiar.
        /// </summary>
        underground_no_ground, // 25
        /// <summary>
        /// Underground, solid rock.
        /// </summary>
        underground_impassable,
        /// <summary>
        /// Underground sea, unswimmable.
        /// </summary>
        underground_ocean,
        /// <summary>
        /// Underground glacier.
        /// </summary>
        underground_frozen,
        /// <summary>
        /// Elemental plane of fire.
        /// </summary>
        plane_of_fire,
        /// <summary>
        /// Elemental plane of air.
        /// </summary>
        plane_of_air, // 30
        /// <summary>
        /// Elemental plane of water.
        /// </summary>
        plane_of_water,
        /// <summary>
        /// Elemental plane of earth.
        /// </summary>
        plane_of_earth,
        /// <summary>
        /// Ethereal plane.
        /// </summary>
        plane_ethereal,
        /// <summary>
        /// Astral plane.
        /// </summary>
        plane_astral
    };

    /// <summary>
    /// Represents the tile overlays used on the surface maps.
    /// 
    /// TODO: Make the tile overlay definitions editable so you can have different tile sets for each MUD.
    /// </summary>
    public enum SecondaryTerrainType
    {
        blank = 0,
        cloud_ash = 1,
        tree_ash = 2,
        bridge_ew = 3,
        bushes = 4,
        cactus = 5,
        castle = 6,
        cave_entrance = 7,
        crater = 8,
        dragon_shadow = 9,
        cloud_dust = 10,
        city_enslaver = 11,
        city_evil = 12,
        cloud_fog = 13,
        shadow_fourlegged = 14,
        city_good = 15,
        grass_green = 16,
        hills_brown = 17,
        hills_brown_cave = 18,
        hills_green = 19,
        hills_green_cave = 20,
        hills_icysnow = 21,
        hills_icysnow_cave = 22,
        shadow_humanoid_large = 23,
        shadow_humanoid_large_w = 24,
        shadow_humanoid_medium = 25,
        shadow_humanoid_medium_w = 26,
        shadow_humanoid_small = 27,
        shadow_humanoid_small_w = 28,
        statue_humanoid = 29,
        island = 30,
        tree_jungle = 31,
        ladder_down = 32,
        ladder_up = 33,
        library = 34,
        mansion = 35,
        tree_maple = 36,
        mountain = 37,
        mountain_cave = 38,
        mountain_snow = 39,
        mountain_snow_cave = 40,
        city_neutral = 41,
        tree_oak = 42,
        obelisk = 43,
        tree_palm = 44,
        pier_ns = 45,
        tree_pine = 46,
        pit = 47,
        cloud_poison = 48,
        pool = 49,
        primitive_hut = 50,
        primitive_village = 51,
        pyramid = 52,
        road_ew = 53,
        road_ns = 54,
        road_4way = 55,
        road_corner_ne = 56,
        road_corner_nw = 57,
        road_corner_se = 58,
        road_corner_sw = 59,
        road_tshape_e = 60,
        road_tshape_n = 61,
        road_tshape_s = 62,
        road_tshape_w = 63,
        skeleton_fourlegged = 64,
        skeleton_human = 65,
        skull = 66,
        stalactite = 67,
        stalactite_icy = 68,
        stalagmite = 69,
        stalagmite_icy = 70,
        stones_circle = 71,
        stones_grey = 72,
        stones_mossy = 73,
        stones_sandy = 74,
        tree_swamp = 75,
        temple = 76,
        tombstone = 77,
        tower = 78,
        mushroom_large = 79,
        mushrooms_small = 80,
        volcano = 81,
        well = 82,
        whirlpool = 83,
        grass_yellow = 84,
        bridge_ns = 85,
        pier_ew = 86
    };
}
