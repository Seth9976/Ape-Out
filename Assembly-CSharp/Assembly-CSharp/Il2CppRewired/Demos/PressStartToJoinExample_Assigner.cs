using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppRewired.Demos
{
	// Token: 0x02000217 RID: 535
	public class PressStartToJoinExample_Assigner : MonoBehaviour
	{
		// Token: 0x06004128 RID: 16680 RVA: 0x000F301C File Offset: 0x000F121C
		// Note: this type is marked as 'beforefieldinit'.
		static PressStartToJoinExample_Assigner()
		{
			Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", "PressStartToJoinExample_Assigner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr);
			PressStartToJoinExample_Assigner.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, "instance");
			PressStartToJoinExample_Assigner.NativeFieldInfoPtr_maxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, "maxPlayers");
			PressStartToJoinExample_Assigner.NativeFieldInfoPtr_playerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, "playerMap");
			PressStartToJoinExample_Assigner.NativeFieldInfoPtr_gamePlayerIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, "gamePlayerIdCounter");
			PressStartToJoinExample_Assigner.NativeMethodInfoPtr_GetRewiredPlayer_Public_Static_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100669654);
			PressStartToJoinExample_Assigner.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100669655);
			PressStartToJoinExample_Assigner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100669656);
			PressStartToJoinExample_Assigner.NativeMethodInfoPtr_AssignNextPlayer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100669657);
			PressStartToJoinExample_Assigner.NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100669658);
			PressStartToJoinExample_Assigner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100669659);
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x000F3114 File Offset: 0x000F1314
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 104808, RefRangeEnd = 104816, XrefRangeStart = 104775, XrefRangeEnd = 104808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Player GetRewiredPlayer(int gamePlayerId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gamePlayerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr_GetRewiredPlayer_Public_Static_Player_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x000F3154 File Offset: 0x000F1354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104816, XrefRangeEnd = 104824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x000F3188 File Offset: 0x000F1388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104824, XrefRangeEnd = 104838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x000F31BC File Offset: 0x000F13BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 104870, RefRangeEnd = 104871, XrefRangeStart = 104838, XrefRangeEnd = 104870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignNextPlayer(int rewiredPlayerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rewiredPlayerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr_AssignNextPlayer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x000F31FC File Offset: 0x000F13FC
		[CallerCount(0)]
		public unsafe int GetNextGamePlayerId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x000F3238 File Offset: 0x000F1438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104871, XrefRangeEnd = 104874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PressStartToJoinExample_Assigner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x00027C6A File Offset: 0x00025E6A
		public PressStartToJoinExample_Assigner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06004130 RID: 16688 RVA: 0x000F3274 File Offset: 0x000F1474
		// (set) Token: 0x06004131 RID: 16689 RVA: 0x00027C73 File Offset: 0x00025E73
		public unsafe static PressStartToJoinExample_Assigner instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PressStartToJoinExample_Assigner>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06004132 RID: 16690 RVA: 0x000F329C File Offset: 0x000F149C
		// (set) Token: 0x06004133 RID: 16691 RVA: 0x00027C85 File Offset: 0x00025E85
		public unsafe int maxPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_maxPlayers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_maxPlayers)) = value;
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x000F32C4 File Offset: 0x000F14C4
		// (set) Token: 0x06004135 RID: 16693 RVA: 0x00027CA0 File Offset: 0x00025EA0
		public unsafe List<PressStartToJoinExample_Assigner.PlayerMap> playerMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_playerMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PressStartToJoinExample_Assigner.PlayerMap>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_playerMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x000F32F4 File Offset: 0x000F14F4
		// (set) Token: 0x06004137 RID: 16695 RVA: 0x00027CBF File Offset: 0x00025EBF
		public unsafe int gamePlayerIdCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_gamePlayerIdCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_gamePlayerIdCounter)) = value;
			}
		}

		// Token: 0x04002808 RID: 10248
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04002809 RID: 10249
		private static readonly IntPtr NativeFieldInfoPtr_maxPlayers;

		// Token: 0x0400280A RID: 10250
		private static readonly IntPtr NativeFieldInfoPtr_playerMap;

		// Token: 0x0400280B RID: 10251
		private static readonly IntPtr NativeFieldInfoPtr_gamePlayerIdCounter;

		// Token: 0x0400280C RID: 10252
		private static readonly IntPtr NativeMethodInfoPtr_GetRewiredPlayer_Public_Static_Player_Int32_0;

		// Token: 0x0400280D RID: 10253
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400280E RID: 10254
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400280F RID: 10255
		private static readonly IntPtr NativeMethodInfoPtr_AssignNextPlayer_Private_Void_Int32_0;

		// Token: 0x04002810 RID: 10256
		private static readonly IntPtr NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0;

		// Token: 0x04002811 RID: 10257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003AA RID: 938
		public class PlayerMap : global::Il2CppSystem.Object
		{
			// Token: 0x0600590A RID: 22794 RVA: 0x00142A38 File Offset: 0x00140C38
			// Note: this type is marked as 'beforefieldinit'.
			static PlayerMap()
			{
				Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, "PlayerMap");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr);
				PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr, "rewiredPlayerId");
				PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_gamePlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr, "gamePlayerId");
				PressStartToJoinExample_Assigner.PlayerMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr, 100669660);
			}

			// Token: 0x0600590B RID: 22795 RVA: 0x00142AA0 File Offset: 0x00140CA0
			[CallerCount(0)]
			public unsafe PlayerMap(int rewiredPlayerId, int gamePlayerId)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref rewiredPlayerId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gamePlayerId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.PlayerMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600590C RID: 22796 RVA: 0x00032FDA File Offset: 0x000311DA
			public PlayerMap(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700208C RID: 8332
			// (get) Token: 0x0600590D RID: 22797 RVA: 0x00142AF8 File Offset: 0x00140CF8
			// (set) Token: 0x0600590E RID: 22798 RVA: 0x00032FE3 File Offset: 0x000311E3
			public unsafe int rewiredPlayerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_rewiredPlayerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_rewiredPlayerId)) = value;
				}
			}

			// Token: 0x1700208D RID: 8333
			// (get) Token: 0x0600590F RID: 22799 RVA: 0x00142B20 File Offset: 0x00140D20
			// (set) Token: 0x06005910 RID: 22800 RVA: 0x00032FFE File Offset: 0x000311FE
			public unsafe int gamePlayerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_gamePlayerId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_gamePlayerId)) = value;
				}
			}

			// Token: 0x04003B2F RID: 15151
			private static readonly IntPtr NativeFieldInfoPtr_rewiredPlayerId;

			// Token: 0x04003B30 RID: 15152
			private static readonly IntPtr NativeFieldInfoPtr_gamePlayerId;

			// Token: 0x04003B31 RID: 15153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
		}
	}
}
