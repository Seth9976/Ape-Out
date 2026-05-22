using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x02000216 RID: 534
	public class PressAnyButtonToJoinExample_GamePlayer : MonoBehaviour
	{
		// Token: 0x06004112 RID: 16658 RVA: 0x000F2C74 File Offset: 0x000F0E74
		// Note: this type is marked as 'beforefieldinit'.
		static PressAnyButtonToJoinExample_GamePlayer()
		{
			Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "PressAnyButtonToJoinExample_GamePlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr);
			PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, "playerId");
			PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, "moveSpeed");
			PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, "bulletSpeed");
			PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, "bulletPrefab");
			PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, "cc");
			PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, "moveVector");
			PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_fire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, "fire");
			PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100669648);
			PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100669649);
			PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100669650);
			PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_GetInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100669651);
			PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_ProcessInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100669652);
			PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100669653);
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06004113 RID: 16659 RVA: 0x000F2DA8 File Offset: 0x000F0FA8
		public unsafe Player player
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 104706, RefRangeEnd = 104713, XrefRangeStart = 104698, XrefRangeEnd = 104706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x000F2DE8 File Offset: 0x000F0FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104713, XrefRangeEnd = 104716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x000F2E1C File Offset: 0x000F101C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104716, XrefRangeEnd = 104734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x000F2E50 File Offset: 0x000F1050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104734, XrefRangeEnd = 104746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_GetInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x000F2E84 File Offset: 0x000F1084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104774, RefRangeEnd = 104775, XrefRangeStart = 104746, XrefRangeEnd = 104774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_ProcessInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x000F2EB8 File Offset: 0x000F10B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressAnyButtonToJoinExample_GamePlayer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x00027B9C File Offset: 0x00025D9C
		public PressAnyButtonToJoinExample_GamePlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x0600411A RID: 16666 RVA: 0x000F2EF4 File Offset: 0x000F10F4
		// (set) Token: 0x0600411B RID: 16667 RVA: 0x00027BA5 File Offset: 0x00025DA5
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x000F2F1C File Offset: 0x000F111C
		// (set) Token: 0x0600411D RID: 16669 RVA: 0x00027BC0 File Offset: 0x00025DC0
		public unsafe float moveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveSpeed)) = value;
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x000F2F44 File Offset: 0x000F1144
		// (set) Token: 0x0600411F RID: 16671 RVA: 0x00027BDB File Offset: 0x00025DDB
		public unsafe float bulletSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletSpeed)) = value;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06004120 RID: 16672 RVA: 0x000F2F6C File Offset: 0x000F116C
		// (set) Token: 0x06004121 RID: 16673 RVA: 0x00027BF6 File Offset: 0x00025DF6
		public unsafe GameObject bulletPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06004122 RID: 16674 RVA: 0x000F2F9C File Offset: 0x000F119C
		// (set) Token: 0x06004123 RID: 16675 RVA: 0x00027C15 File Offset: 0x00025E15
		public unsafe CharacterController cc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_cc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_cc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x06004124 RID: 16676 RVA: 0x000F2FCC File Offset: 0x000F11CC
		// (set) Token: 0x06004125 RID: 16677 RVA: 0x00027C34 File Offset: 0x00025E34
		public unsafe Vector3 moveVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveVector)) = value;
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06004126 RID: 16678 RVA: 0x000F2FF4 File Offset: 0x000F11F4
		// (set) Token: 0x06004127 RID: 16679 RVA: 0x00027C4F File Offset: 0x00025E4F
		public unsafe bool fire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_fire);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_fire)) = value;
			}
		}

		// Token: 0x040027FB RID: 10235
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x040027FC RID: 10236
		private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;

		// Token: 0x040027FD RID: 10237
		private static readonly IntPtr NativeFieldInfoPtr_bulletSpeed;

		// Token: 0x040027FE RID: 10238
		private static readonly IntPtr NativeFieldInfoPtr_bulletPrefab;

		// Token: 0x040027FF RID: 10239
		private static readonly IntPtr NativeFieldInfoPtr_cc;

		// Token: 0x04002800 RID: 10240
		private static readonly IntPtr NativeFieldInfoPtr_moveVector;

		// Token: 0x04002801 RID: 10241
		private static readonly IntPtr NativeFieldInfoPtr_fire;

		// Token: 0x04002802 RID: 10242
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;

		// Token: 0x04002803 RID: 10243
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04002804 RID: 10244
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002805 RID: 10245
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Private_Void_0;

		// Token: 0x04002806 RID: 10246
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInput_Private_Void_0;

		// Token: 0x04002807 RID: 10247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
