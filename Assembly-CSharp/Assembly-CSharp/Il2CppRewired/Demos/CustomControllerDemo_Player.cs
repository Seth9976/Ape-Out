using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x0200020C RID: 524
	public class CustomControllerDemo_Player : MonoBehaviour
	{
		// Token: 0x0600402E RID: 16430 RVA: 0x000F01B0 File Offset: 0x000EE3B0
		// Note: this type is marked as 'beforefieldinit'.
		static CustomControllerDemo_Player()
		{
			Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "CustomControllerDemo_Player");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr);
			CustomControllerDemo_Player.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr, "playerId");
			CustomControllerDemo_Player.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr, "speed");
			CustomControllerDemo_Player.NativeFieldInfoPtr_bulletSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr, "bulletSpeed");
			CustomControllerDemo_Player.NativeFieldInfoPtr_bulletPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr, "bulletPrefab");
			CustomControllerDemo_Player.NativeFieldInfoPtr__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr, "_player");
			CustomControllerDemo_Player.NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr, "cc");
			CustomControllerDemo_Player.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr, 100669561);
			CustomControllerDemo_Player.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr, 100669562);
			CustomControllerDemo_Player.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr, 100669563);
			CustomControllerDemo_Player.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr, 100669564);
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x0600402F RID: 16431 RVA: 0x000F02A8 File Offset: 0x000EE4A8
		public unsafe Player player
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 103256, RefRangeEnd = 103260, XrefRangeStart = 103251, XrefRangeEnd = 103256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo_Player.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x000F02E8 File Offset: 0x000EE4E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103260, XrefRangeEnd = 103263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo_Player.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x000F031C File Offset: 0x000EE51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103263, XrefRangeEnd = 103319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo_Player.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x000F0350 File Offset: 0x000EE550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103319, XrefRangeEnd = 103322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomControllerDemo_Player()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomControllerDemo_Player>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomControllerDemo_Player.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x0002748D File Offset: 0x0002568D
		public CustomControllerDemo_Player(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700184C RID: 6220
		// (get) Token: 0x06004034 RID: 16436 RVA: 0x000F038C File Offset: 0x000EE58C
		// (set) Token: 0x06004035 RID: 16437 RVA: 0x00027496 File Offset: 0x00025696
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x1700184D RID: 6221
		// (get) Token: 0x06004036 RID: 16438 RVA: 0x000F03B4 File Offset: 0x000EE5B4
		// (set) Token: 0x06004037 RID: 16439 RVA: 0x000274B1 File Offset: 0x000256B1
		public unsafe float speed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr_speed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr_speed)) = value;
			}
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x06004038 RID: 16440 RVA: 0x000F03DC File Offset: 0x000EE5DC
		// (set) Token: 0x06004039 RID: 16441 RVA: 0x000274CC File Offset: 0x000256CC
		public unsafe float bulletSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr_bulletSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr_bulletSpeed)) = value;
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x0600403A RID: 16442 RVA: 0x000F0404 File Offset: 0x000EE604
		// (set) Token: 0x0600403B RID: 16443 RVA: 0x000274E7 File Offset: 0x000256E7
		public unsafe GameObject bulletPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr_bulletPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr_bulletPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x0600403C RID: 16444 RVA: 0x000F0434 File Offset: 0x000EE634
		// (set) Token: 0x0600403D RID: 16445 RVA: 0x00027506 File Offset: 0x00025706
		public unsafe Player _player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr__player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr__player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x0600403E RID: 16446 RVA: 0x000F0464 File Offset: 0x000EE664
		// (set) Token: 0x0600403F RID: 16447 RVA: 0x00027525 File Offset: 0x00025725
		public unsafe CharacterController cc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr_cc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomControllerDemo_Player.NativeFieldInfoPtr_cc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002769 RID: 10089
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x0400276A RID: 10090
		private static readonly IntPtr NativeFieldInfoPtr_speed;

		// Token: 0x0400276B RID: 10091
		private static readonly IntPtr NativeFieldInfoPtr_bulletSpeed;

		// Token: 0x0400276C RID: 10092
		private static readonly IntPtr NativeFieldInfoPtr_bulletPrefab;

		// Token: 0x0400276D RID: 10093
		private static readonly IntPtr NativeFieldInfoPtr__player;

		// Token: 0x0400276E RID: 10094
		private static readonly IntPtr NativeFieldInfoPtr_cc;

		// Token: 0x0400276F RID: 10095
		private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;

		// Token: 0x04002770 RID: 10096
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002771 RID: 10097
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04002772 RID: 10098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
