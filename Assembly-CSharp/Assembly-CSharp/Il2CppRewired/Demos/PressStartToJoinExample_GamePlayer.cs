using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x02000218 RID: 536
	public class PressStartToJoinExample_GamePlayer : MonoBehaviour
	{
		// Token: 0x06004138 RID: 16696 RVA: 0x000F331C File Offset: 0x000F151C
		// Note: this type is marked as 'beforefieldinit'.
		static PressStartToJoinExample_GamePlayer()
		{
			Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "PressStartToJoinExample_GamePlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr);
			PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_gamePlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, "gamePlayerId");
			PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, "moveSpeed");
			PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, "bulletSpeed");
			PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, "bulletPrefab");
			PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, "cc");
			PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_moveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, "moveVector");
			PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_fire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, "fire");
			PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, 100669661);
			PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, 100669662);
			PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, 100669663);
			PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr_GetInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, 100669664);
			PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr_ProcessInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, 100669665);
			PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr, 100669666);
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06004139 RID: 16697 RVA: 0x000F3450 File Offset: 0x000F1650
		public unsafe Player player
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104874, XrefRangeEnd = 104875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x000F3490 File Offset: 0x000F1690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104875, XrefRangeEnd = 104878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x000F34C4 File Offset: 0x000F16C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104878, XrefRangeEnd = 104896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x000F34F8 File Offset: 0x000F16F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104896, XrefRangeEnd = 104908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr_GetInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x000F352C File Offset: 0x000F172C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104936, RefRangeEnd = 104937, XrefRangeStart = 104908, XrefRangeEnd = 104936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr_ProcessInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x000F3560 File Offset: 0x000F1760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressStartToJoinExample_GamePlayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressStartToJoinExample_GamePlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_GamePlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x00027CDA File Offset: 0x00025EDA
		public PressStartToJoinExample_GamePlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06004140 RID: 16704 RVA: 0x000F359C File Offset: 0x000F179C
		// (set) Token: 0x06004141 RID: 16705 RVA: 0x00027CE3 File Offset: 0x00025EE3
		public unsafe int gamePlayerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_gamePlayerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_gamePlayerId)) = value;
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06004142 RID: 16706 RVA: 0x000F35C4 File Offset: 0x000F17C4
		// (set) Token: 0x06004143 RID: 16707 RVA: 0x00027CFE File Offset: 0x00025EFE
		public unsafe float moveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_moveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_moveSpeed)) = value;
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06004144 RID: 16708 RVA: 0x000F35EC File Offset: 0x000F17EC
		// (set) Token: 0x06004145 RID: 16709 RVA: 0x00027D19 File Offset: 0x00025F19
		public unsafe float bulletSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletSpeed)) = value;
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06004146 RID: 16710 RVA: 0x000F3614 File Offset: 0x000F1814
		// (set) Token: 0x06004147 RID: 16711 RVA: 0x00027D34 File Offset: 0x00025F34
		public unsafe GameObject bulletPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06004148 RID: 16712 RVA: 0x000F3644 File Offset: 0x000F1844
		// (set) Token: 0x06004149 RID: 16713 RVA: 0x00027D53 File Offset: 0x00025F53
		public unsafe CharacterController cc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_cc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_cc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x0600414A RID: 16714 RVA: 0x000F3674 File Offset: 0x000F1874
		// (set) Token: 0x0600414B RID: 16715 RVA: 0x00027D72 File Offset: 0x00025F72
		public unsafe Vector3 moveVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_moveVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_moveVector)) = value;
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x0600414C RID: 16716 RVA: 0x000F369C File Offset: 0x000F189C
		// (set) Token: 0x0600414D RID: 16717 RVA: 0x00027D8D File Offset: 0x00025F8D
		public unsafe bool fire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_fire);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_GamePlayer.NativeFieldInfoPtr_fire)) = value;
			}
		}

		// Token: 0x04002812 RID: 10258
		private static readonly IntPtr NativeFieldInfoPtr_gamePlayerId;

		// Token: 0x04002813 RID: 10259
		private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;

		// Token: 0x04002814 RID: 10260
		private static readonly IntPtr NativeFieldInfoPtr_bulletSpeed;

		// Token: 0x04002815 RID: 10261
		private static readonly IntPtr NativeFieldInfoPtr_bulletPrefab;

		// Token: 0x04002816 RID: 10262
		private static readonly IntPtr NativeFieldInfoPtr_cc;

		// Token: 0x04002817 RID: 10263
		private static readonly IntPtr NativeFieldInfoPtr_moveVector;

		// Token: 0x04002818 RID: 10264
		private static readonly IntPtr NativeFieldInfoPtr_fire;

		// Token: 0x04002819 RID: 10265
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;

		// Token: 0x0400281A RID: 10266
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400281B RID: 10267
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400281C RID: 10268
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Private_Void_0;

		// Token: 0x0400281D RID: 10269
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInput_Private_Void_0;

		// Token: 0x0400281E RID: 10270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
