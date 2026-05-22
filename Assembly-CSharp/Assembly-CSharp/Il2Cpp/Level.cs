using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x0200011B RID: 283
	public class Level : ScriptableObject
	{
		// Token: 0x06002206 RID: 8710 RVA: 0x000931C4 File Offset: 0x000913C4
		// Note: this type is marked as 'beforefieldinit'.
		static Level()
		{
			Il2CppClassPointerStore<Level>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Level");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Level>.NativeClassPtr);
			Level.NativeFieldInfoPtr_layout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "layout");
			Level.NativeFieldInfoPtr_layoutHard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "layoutHard");
			Level.NativeFieldInfoPtr_parTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "parTime");
			Level.NativeFieldInfoPtr_bags1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "bags1");
			Level.NativeFieldInfoPtr_bags2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "bags2");
			Level.NativeFieldInfoPtr_fatBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "fatBag");
			Level.NativeFieldInfoPtr_fatNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "fatNum");
			Level.NativeFieldInfoPtr_doorProb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "doorProb");
			Level.NativeFieldInfoPtr_glassProb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "glassProb");
			Level.NativeFieldInfoPtr_glassDoorProb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "glassDoorProb");
			Level.NativeFieldInfoPtr_stealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "stealthLevel");
			Level.NativeFieldInfoPtr_primaryPalette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "primaryPalette");
			Level.NativeFieldInfoPtr_secondaryPalette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "secondaryPalette");
			Level.NativeFieldInfoPtr_tertiaryPalette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "tertiaryPalette");
			Level.NativeFieldInfoPtr_secondaryPaletteStaticTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "secondaryPaletteStaticTiles");
			Level.NativeFieldInfoPtr_tertiaryPaletteStaticTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "tertiaryPaletteStaticTiles");
			Level.NativeFieldInfoPtr_transitionPalNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "transitionPalNum");
			Level.NativeFieldInfoPtr_dontCountAsMapForDeadScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "dontCountAsMapForDeadScreen");
			Level.NativeFieldInfoPtr_hasLedges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "hasLedges");
			Level.NativeFieldInfoPtr_animalPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "animalPrefabs");
			Level.NativeFieldInfoPtr_civChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "civChance");
			Level.NativeFieldInfoPtr_levelNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "levelNum");
			Level.NativeFieldInfoPtr_specialLevelFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "specialLevelFolder");
			Level.NativeFieldInfoPtr_startUncaged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "startUncaged");
			Level.NativeFieldInfoPtr_startRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "startRunning");
			Level.NativeFieldInfoPtr_goLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "goLeft");
			Level.NativeFieldInfoPtr_vertLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "vertLimit");
			Level.NativeFieldInfoPtr_transitionIsStartTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "transitionIsStartTile");
			Level.NativeFieldInfoPtr_dontUseDeadStripe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "dontUseDeadStripe");
			Level.NativeFieldInfoPtr_hasOverhangs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "hasOverhangs");
			Level.NativeFieldInfoPtr_trimDeadFloorQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "trimDeadFloorQuad");
			Level.NativeFieldInfoPtr_seqPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "seqPatch");
			Level.NativeFieldInfoPtr_alSeqPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "alSeqPatch");
			Level.NativeFieldInfoPtr_sampPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "sampPatch");
			Level.NativeFieldInfoPtr_altSampPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "altSampPatch");
			Level.NativeFieldInfoPtr_mixPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "mixPatch");
			Level.NativeFieldInfoPtr_floorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "floorMaterial");
			Level.NativeFieldInfoPtr_secondaryFloorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "secondaryFloorMaterial");
			Level.NativeFieldInfoPtr_tertiaryFloorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "tertiaryFloorMaterial");
			Level.NativeFieldInfoPtr_primaryAmb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "primaryAmb");
			Level.NativeFieldInfoPtr_secondaryAmb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "secondaryAmb");
			Level.NativeFieldInfoPtr_tertiaryAmb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "tertiaryAmb");
			Level.NativeFieldInfoPtr_PrimarySectrAmbiance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "PrimarySectrAmbiance");
			Level.NativeFieldInfoPtr_SecondarySectrAmbiance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "SecondarySectrAmbiance");
			Level.NativeFieldInfoPtr_TertiarySectrAmbiance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "TertiarySectrAmbiance");
			Level.NativeFieldInfoPtr_primaryRoomPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "primaryRoomPatch");
			Level.NativeFieldInfoPtr_secondaryRoomPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "secondaryRoomPatch");
			Level.NativeFieldInfoPtr_tertiaryRoomPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "tertiaryRoomPatch");
			Level.NativeFieldInfoPtr_primaryReverbPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "primaryReverbPatch");
			Level.NativeFieldInfoPtr_secondaryReverbPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "secondaryReverbPatch");
			Level.NativeFieldInfoPtr_tertiaryReverbPatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level>.NativeClassPtr, "tertiaryReverbPatch");
			Level.NativeMethodInfoPtr_GetAnimal_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Level>.NativeClassPtr, 100665963);
			Level.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Level>.NativeClassPtr, 100665964);
		}

		// Token: 0x06002207 RID: 8711 RVA: 0x00093618 File Offset: 0x00091818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69153, XrefRangeEnd = 69155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject GetAnimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Level.NativeMethodInfoPtr_GetAnimal_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00093658 File Offset: 0x00091858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69155, XrefRangeEnd = 69156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Level()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Level>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Level.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00017D44 File Offset: 0x00015F44
		public Level(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x00093694 File Offset: 0x00091894
		// (set) Token: 0x0600220B RID: 8715 RVA: 0x00017D4D File Offset: 0x00015F4D
		public unsafe TextAsset layout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_layout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_layout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x0600220C RID: 8716 RVA: 0x000936C4 File Offset: 0x000918C4
		// (set) Token: 0x0600220D RID: 8717 RVA: 0x00017D6C File Offset: 0x00015F6C
		public unsafe TextAsset layoutHard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_layoutHard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_layoutHard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x000936F4 File Offset: 0x000918F4
		// (set) Token: 0x0600220F RID: 8719 RVA: 0x00017D8B File Offset: 0x00015F8B
		public unsafe int parTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_parTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_parTime)) = value;
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002210 RID: 8720 RVA: 0x0009371C File Offset: 0x0009191C
		// (set) Token: 0x06002211 RID: 8721 RVA: 0x00017DA6 File Offset: 0x00015FA6
		public unsafe Il2CppReferenceArray<Bag> bags1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_bags1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Bag>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_bags1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002212 RID: 8722 RVA: 0x0009374C File Offset: 0x0009194C
		// (set) Token: 0x06002213 RID: 8723 RVA: 0x00017DC5 File Offset: 0x00015FC5
		public unsafe Il2CppReferenceArray<Bag> bags2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_bags2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Bag>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_bags2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002214 RID: 8724 RVA: 0x0009377C File Offset: 0x0009197C
		// (set) Token: 0x06002215 RID: 8725 RVA: 0x00017DE4 File Offset: 0x00015FE4
		public unsafe Bag fatBag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_fatBag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bag>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_fatBag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002216 RID: 8726 RVA: 0x000937AC File Offset: 0x000919AC
		// (set) Token: 0x06002217 RID: 8727 RVA: 0x00017E03 File Offset: 0x00016003
		public unsafe int fatNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_fatNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_fatNum)) = value;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002218 RID: 8728 RVA: 0x000937D4 File Offset: 0x000919D4
		// (set) Token: 0x06002219 RID: 8729 RVA: 0x00017E1E File Offset: 0x0001601E
		public unsafe float doorProb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_doorProb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_doorProb)) = value;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x000937FC File Offset: 0x000919FC
		// (set) Token: 0x0600221B RID: 8731 RVA: 0x00017E39 File Offset: 0x00016039
		public unsafe float glassProb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_glassProb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_glassProb)) = value;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x00093824 File Offset: 0x00091A24
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x00017E54 File Offset: 0x00016054
		public unsafe float glassDoorProb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_glassDoorProb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_glassDoorProb)) = value;
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x0009384C File Offset: 0x00091A4C
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x00017E6F File Offset: 0x0001606F
		public unsafe bool stealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_stealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_stealthLevel)) = value;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x00093874 File Offset: 0x00091A74
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x00017E8A File Offset: 0x0001608A
		public unsafe Texture primaryPalette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_primaryPalette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_primaryPalette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x000938A4 File Offset: 0x00091AA4
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x00017EA9 File Offset: 0x000160A9
		public unsafe Texture secondaryPalette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryPalette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryPalette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x000938D4 File Offset: 0x00091AD4
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x00017EC8 File Offset: 0x000160C8
		public unsafe Texture tertiaryPalette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryPalette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryPalette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x00093904 File Offset: 0x00091B04
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x00017EE7 File Offset: 0x000160E7
		public unsafe Il2CppStructArray<char> secondaryPaletteStaticTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryPaletteStaticTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryPaletteStaticTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x00093934 File Offset: 0x00091B34
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x00017F06 File Offset: 0x00016106
		public unsafe Il2CppStructArray<char> tertiaryPaletteStaticTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryPaletteStaticTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryPaletteStaticTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x00093964 File Offset: 0x00091B64
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x00017F25 File Offset: 0x00016125
		public unsafe int transitionPalNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_transitionPalNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_transitionPalNum)) = value;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x0009398C File Offset: 0x00091B8C
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x00017F40 File Offset: 0x00016140
		public unsafe Il2CppStructArray<char> dontCountAsMapForDeadScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_dontCountAsMapForDeadScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_dontCountAsMapForDeadScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x000939BC File Offset: 0x00091BBC
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x00017F5F File Offset: 0x0001615F
		public unsafe bool hasLedges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_hasLedges);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_hasLedges)) = value;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x000939E4 File Offset: 0x00091BE4
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x00017F7A File Offset: 0x0001617A
		public unsafe Il2CppReferenceArray<GameObject> animalPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_animalPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_animalPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x00093A14 File Offset: 0x00091C14
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x00017F99 File Offset: 0x00016199
		public unsafe float civChance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_civChance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_civChance)) = value;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x00093A3C File Offset: 0x00091C3C
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x00017FB4 File Offset: 0x000161B4
		public unsafe int levelNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_levelNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_levelNum)) = value;
			}
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x00093A64 File Offset: 0x00091C64
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x00017FCF File Offset: 0x000161CF
		public unsafe string specialLevelFolder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_specialLevelFolder);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_specialLevelFolder), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x00093A8C File Offset: 0x00091C8C
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x00017FEE File Offset: 0x000161EE
		public unsafe bool startUncaged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_startUncaged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_startUncaged)) = value;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x00093AB4 File Offset: 0x00091CB4
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x00018009 File Offset: 0x00016209
		public unsafe bool startRunning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_startRunning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_startRunning)) = value;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x00093ADC File Offset: 0x00091CDC
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x00018024 File Offset: 0x00016224
		public unsafe bool goLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_goLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_goLeft)) = value;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x00093B04 File Offset: 0x00091D04
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x0001803F File Offset: 0x0001623F
		public unsafe bool vertLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_vertLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_vertLimit)) = value;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x00093B2C File Offset: 0x00091D2C
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x0001805A File Offset: 0x0001625A
		public unsafe bool transitionIsStartTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_transitionIsStartTile);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_transitionIsStartTile)) = value;
			}
		}

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x00093B54 File Offset: 0x00091D54
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x00018075 File Offset: 0x00016275
		public unsafe bool dontUseDeadStripe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_dontUseDeadStripe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_dontUseDeadStripe)) = value;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x00093B7C File Offset: 0x00091D7C
		// (set) Token: 0x06002245 RID: 8773 RVA: 0x00018090 File Offset: 0x00016290
		public unsafe bool hasOverhangs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_hasOverhangs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_hasOverhangs)) = value;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x00093BA4 File Offset: 0x00091DA4
		// (set) Token: 0x06002247 RID: 8775 RVA: 0x000180AB File Offset: 0x000162AB
		public unsafe bool trimDeadFloorQuad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_trimDeadFloorQuad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_trimDeadFloorQuad)) = value;
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x00093BCC File Offset: 0x00091DCC
		// (set) Token: 0x06002249 RID: 8777 RVA: 0x000180C6 File Offset: 0x000162C6
		public unsafe MusicSystem.LevelSequencerPatch seqPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_seqPatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_seqPatch)) = value;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x00093BF4 File Offset: 0x00091DF4
		// (set) Token: 0x0600224B RID: 8779 RVA: 0x000180E1 File Offset: 0x000162E1
		public unsafe MusicSystem.LevelSequencerPatch alSeqPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_alSeqPatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_alSeqPatch)) = value;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x0600224C RID: 8780 RVA: 0x00093C1C File Offset: 0x00091E1C
		// (set) Token: 0x0600224D RID: 8781 RVA: 0x000180FC File Offset: 0x000162FC
		public unsafe MusicSystem.LevelSamplerPatch sampPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_sampPatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_sampPatch)) = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x0600224E RID: 8782 RVA: 0x00093C44 File Offset: 0x00091E44
		// (set) Token: 0x0600224F RID: 8783 RVA: 0x00018117 File Offset: 0x00016317
		public unsafe MusicSystem.LevelSamplerPatch altSampPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_altSampPatch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_altSampPatch)) = value;
			}
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06002250 RID: 8784 RVA: 0x00093C6C File Offset: 0x00091E6C
		// (set) Token: 0x06002251 RID: 8785 RVA: 0x00018132 File Offset: 0x00016332
		public unsafe ListenerControllerPatch mixPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_mixPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListenerControllerPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_mixPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x00093C9C File Offset: 0x00091E9C
		// (set) Token: 0x06002253 RID: 8787 RVA: 0x00018151 File Offset: 0x00016351
		public unsafe Level.FloorMaterial floorMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_floorMaterial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_floorMaterial)) = value;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x00093CC4 File Offset: 0x00091EC4
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x0001816C File Offset: 0x0001636C
		public unsafe Level.FloorMaterial secondaryFloorMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryFloorMaterial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryFloorMaterial)) = value;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x00093CEC File Offset: 0x00091EEC
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x00018187 File Offset: 0x00016387
		public unsafe Level.FloorMaterial tertiaryFloorMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryFloorMaterial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryFloorMaterial)) = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002258 RID: 8792 RVA: 0x00093D14 File Offset: 0x00091F14
		// (set) Token: 0x06002259 RID: 8793 RVA: 0x000181A2 File Offset: 0x000163A2
		public unsafe AudioClip primaryAmb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_primaryAmb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_primaryAmb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x00093D44 File Offset: 0x00091F44
		// (set) Token: 0x0600225B RID: 8795 RVA: 0x000181C1 File Offset: 0x000163C1
		public unsafe AudioClip secondaryAmb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryAmb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryAmb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x00093D74 File Offset: 0x00091F74
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x000181E0 File Offset: 0x000163E0
		public unsafe AudioClip tertiaryAmb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryAmb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryAmb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x00093DA4 File Offset: 0x00091FA4
		// (set) Token: 0x0600225F RID: 8799 RVA: 0x000181FF File Offset: 0x000163FF
		public unsafe SECTR_AudioAmbience PrimarySectrAmbiance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_PrimarySectrAmbiance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioAmbience>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_PrimarySectrAmbiance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x00093DD4 File Offset: 0x00091FD4
		// (set) Token: 0x06002261 RID: 8801 RVA: 0x0001821E File Offset: 0x0001641E
		public unsafe SECTR_AudioAmbience SecondarySectrAmbiance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_SecondarySectrAmbiance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioAmbience>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_SecondarySectrAmbiance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x00093E04 File Offset: 0x00092004
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x0001823D File Offset: 0x0001643D
		public unsafe SECTR_AudioAmbience TertiarySectrAmbiance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_TertiarySectrAmbiance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SECTR_AudioAmbience>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_TertiarySectrAmbiance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x00093E34 File Offset: 0x00092034
		// (set) Token: 0x06002265 RID: 8805 RVA: 0x0001825C File Offset: 0x0001645C
		public unsafe ResonanceRoomPatch primaryRoomPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_primaryRoomPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceRoomPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_primaryRoomPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x00093E64 File Offset: 0x00092064
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x0001827B File Offset: 0x0001647B
		public unsafe ResonanceRoomPatch secondaryRoomPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryRoomPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceRoomPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryRoomPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x00093E94 File Offset: 0x00092094
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x0001829A File Offset: 0x0001649A
		public unsafe ResonanceRoomPatch tertiaryRoomPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryRoomPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResonanceRoomPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryRoomPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x00093EC4 File Offset: 0x000920C4
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x000182B9 File Offset: 0x000164B9
		public unsafe ReverbPatch primaryReverbPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_primaryReverbPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverbPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_primaryReverbPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x00093EF4 File Offset: 0x000920F4
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x000182D8 File Offset: 0x000164D8
		public unsafe ReverbPatch secondaryReverbPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryReverbPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverbPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_secondaryReverbPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x00093F24 File Offset: 0x00092124
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x000182F7 File Offset: 0x000164F7
		public unsafe ReverbPatch tertiaryReverbPatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryReverbPatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReverbPatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Level.NativeFieldInfoPtr_tertiaryReverbPatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeFieldInfoPtr_layout;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeFieldInfoPtr_layoutHard;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeFieldInfoPtr_parTime;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeFieldInfoPtr_bags1;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeFieldInfoPtr_bags2;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeFieldInfoPtr_fatBag;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeFieldInfoPtr_fatNum;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeFieldInfoPtr_doorProb;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeFieldInfoPtr_glassProb;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeFieldInfoPtr_glassDoorProb;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeFieldInfoPtr_stealthLevel;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeFieldInfoPtr_primaryPalette;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeFieldInfoPtr_secondaryPalette;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeFieldInfoPtr_tertiaryPalette;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeFieldInfoPtr_secondaryPaletteStaticTiles;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeFieldInfoPtr_tertiaryPaletteStaticTiles;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeFieldInfoPtr_transitionPalNum;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeFieldInfoPtr_dontCountAsMapForDeadScreen;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeFieldInfoPtr_hasLedges;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeFieldInfoPtr_animalPrefabs;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeFieldInfoPtr_civChance;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeFieldInfoPtr_levelNum;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeFieldInfoPtr_specialLevelFolder;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeFieldInfoPtr_startUncaged;

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeFieldInfoPtr_startRunning;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeFieldInfoPtr_goLeft;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeFieldInfoPtr_vertLimit;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeFieldInfoPtr_transitionIsStartTile;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeFieldInfoPtr_dontUseDeadStripe;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeFieldInfoPtr_hasOverhangs;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeFieldInfoPtr_trimDeadFloorQuad;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeFieldInfoPtr_seqPatch;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeFieldInfoPtr_alSeqPatch;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeFieldInfoPtr_sampPatch;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeFieldInfoPtr_altSampPatch;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeFieldInfoPtr_mixPatch;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeFieldInfoPtr_floorMaterial;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeFieldInfoPtr_secondaryFloorMaterial;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeFieldInfoPtr_tertiaryFloorMaterial;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeFieldInfoPtr_primaryAmb;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeFieldInfoPtr_secondaryAmb;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr_tertiaryAmb;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeFieldInfoPtr_PrimarySectrAmbiance;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeFieldInfoPtr_SecondarySectrAmbiance;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeFieldInfoPtr_TertiarySectrAmbiance;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeFieldInfoPtr_primaryRoomPatch;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeFieldInfoPtr_secondaryRoomPatch;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeFieldInfoPtr_tertiaryRoomPatch;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeFieldInfoPtr_primaryReverbPatch;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeFieldInfoPtr_secondaryReverbPatch;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeFieldInfoPtr_tertiaryReverbPatch;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_GetAnimal_Public_GameObject_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000316 RID: 790
		[OriginalName("Assembly-CSharp.dll", "", "FloorMaterial")]
		public enum FloorMaterial
		{
			// Token: 0x040034DE RID: 13534
			Grass,
			// Token: 0x040034DF RID: 13535
			Concrete,
			// Token: 0x040034E0 RID: 13536
			Carpet,
			// Token: 0x040034E1 RID: 13537
			Parquet,
			// Token: 0x040034E2 RID: 13538
			Marble,
			// Token: 0x040034E3 RID: 13539
			Linoleum,
			// Token: 0x040034E4 RID: 13540
			Metal,
			// Token: 0x040034E5 RID: 13541
			Wood,
			// Token: 0x040034E6 RID: 13542
			Timber,
			// Token: 0x040034E7 RID: 13543
			Asphalt
		}
	}
}
