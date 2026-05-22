using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x02000210 RID: 528
	public class EightPlayersExample_Player : MonoBehaviour
	{
		// Token: 0x0600408E RID: 16526 RVA: 0x000F13E4 File Offset: 0x000EF5E4
		// Note: this type is marked as 'beforefieldinit'.
		static EightPlayersExample_Player()
		{
			Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "EightPlayersExample_Player");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr);
			EightPlayersExample_Player.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, "playerId");
			EightPlayersExample_Player.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, "moveSpeed");
			EightPlayersExample_Player.NativeFieldInfoPtr_bulletSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, "bulletSpeed");
			EightPlayersExample_Player.NativeFieldInfoPtr_bulletPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, "bulletPrefab");
			EightPlayersExample_Player.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, "player");
			EightPlayersExample_Player.NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, "cc");
			EightPlayersExample_Player.NativeFieldInfoPtr_moveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, "moveVector");
			EightPlayersExample_Player.NativeFieldInfoPtr_fire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, "fire");
			EightPlayersExample_Player.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, "initialized");
			EightPlayersExample_Player.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100669600);
			EightPlayersExample_Player.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100669601);
			EightPlayersExample_Player.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100669602);
			EightPlayersExample_Player.NativeMethodInfoPtr_GetInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100669603);
			EightPlayersExample_Player.NativeMethodInfoPtr_ProcessInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100669604);
			EightPlayersExample_Player.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100669605);
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x000F1540 File Offset: 0x000EF740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103767, XrefRangeEnd = 103770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x000F1574 File Offset: 0x000EF774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103770, XrefRangeEnd = 103775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x000F15A8 File Offset: 0x000EF7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103775, XrefRangeEnd = 103794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x000F15DC File Offset: 0x000EF7DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103794, XrefRangeEnd = 103803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr_GetInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x000F1610 File Offset: 0x000EF810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 103831, RefRangeEnd = 103832, XrefRangeStart = 103803, XrefRangeEnd = 103831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr_ProcessInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x000F1644 File Offset: 0x000EF844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103832, XrefRangeEnd = 103835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EightPlayersExample_Player()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004095 RID: 16533 RVA: 0x00027786 File Offset: 0x00025986
		public EightPlayersExample_Player(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06004096 RID: 16534 RVA: 0x000F1680 File Offset: 0x000EF880
		// (set) Token: 0x06004097 RID: 16535 RVA: 0x0002778F File Offset: 0x0002598F
		public unsafe int playerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_playerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_playerId)) = value;
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x000F16A8 File Offset: 0x000EF8A8
		// (set) Token: 0x06004099 RID: 16537 RVA: 0x000277AA File Offset: 0x000259AA
		public unsafe float moveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_moveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_moveSpeed)) = value;
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x0600409A RID: 16538 RVA: 0x000F16D0 File Offset: 0x000EF8D0
		// (set) Token: 0x0600409B RID: 16539 RVA: 0x000277C5 File Offset: 0x000259C5
		public unsafe float bulletSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_bulletSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_bulletSpeed)) = value;
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x0600409C RID: 16540 RVA: 0x000F16F8 File Offset: 0x000EF8F8
		// (set) Token: 0x0600409D RID: 16541 RVA: 0x000277E0 File Offset: 0x000259E0
		public unsafe GameObject bulletPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_bulletPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_bulletPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x0600409E RID: 16542 RVA: 0x000F1728 File Offset: 0x000EF928
		// (set) Token: 0x0600409F RID: 16543 RVA: 0x000277FF File Offset: 0x000259FF
		public unsafe Player player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x060040A0 RID: 16544 RVA: 0x000F1758 File Offset: 0x000EF958
		// (set) Token: 0x060040A1 RID: 16545 RVA: 0x0002781E File Offset: 0x00025A1E
		public unsafe CharacterController cc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_cc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_cc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x060040A2 RID: 16546 RVA: 0x000F1788 File Offset: 0x000EF988
		// (set) Token: 0x060040A3 RID: 16547 RVA: 0x0002783D File Offset: 0x00025A3D
		public unsafe Vector3 moveVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_moveVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_moveVector)) = value;
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x000F17B0 File Offset: 0x000EF9B0
		// (set) Token: 0x060040A5 RID: 16549 RVA: 0x00027858 File Offset: 0x00025A58
		public unsafe bool fire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_fire);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_fire)) = value;
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x060040A6 RID: 16550 RVA: 0x000F17D8 File Offset: 0x000EF9D8
		// (set) Token: 0x060040A7 RID: 16551 RVA: 0x00027873 File Offset: 0x00025A73
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x040027A7 RID: 10151
		private static readonly IntPtr NativeFieldInfoPtr_playerId;

		// Token: 0x040027A8 RID: 10152
		private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;

		// Token: 0x040027A9 RID: 10153
		private static readonly IntPtr NativeFieldInfoPtr_bulletSpeed;

		// Token: 0x040027AA RID: 10154
		private static readonly IntPtr NativeFieldInfoPtr_bulletPrefab;

		// Token: 0x040027AB RID: 10155
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x040027AC RID: 10156
		private static readonly IntPtr NativeFieldInfoPtr_cc;

		// Token: 0x040027AD RID: 10157
		private static readonly IntPtr NativeFieldInfoPtr_moveVector;

		// Token: 0x040027AE RID: 10158
		private static readonly IntPtr NativeFieldInfoPtr_fire;

		// Token: 0x040027AF RID: 10159
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x040027B0 RID: 10160
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040027B1 RID: 10161
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;

		// Token: 0x040027B2 RID: 10162
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040027B3 RID: 10163
		private static readonly IntPtr NativeMethodInfoPtr_GetInput_Private_Void_0;

		// Token: 0x040027B4 RID: 10164
		private static readonly IntPtr NativeMethodInfoPtr_ProcessInput_Private_Void_0;

		// Token: 0x040027B5 RID: 10165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
