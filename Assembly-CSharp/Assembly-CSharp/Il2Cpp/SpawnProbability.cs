using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x020001A2 RID: 418
	public class SpawnProbability : MonoBehaviour
	{
		// Token: 0x06003040 RID: 12352 RVA: 0x000B92B8 File Offset: 0x000B74B8
		// Note: this type is marked as 'beforefieldinit'.
		static SpawnProbability()
		{
			Il2CppClassPointerStore<SpawnProbability>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SpawnProbability");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnProbability>.NativeClassPtr);
			SpawnProbability.NativeFieldInfoPtr_odds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnProbability>.NativeClassPtr, "odds");
			SpawnProbability.NativeFieldInfoPtr_added = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnProbability>.NativeClassPtr, "added");
			SpawnProbability.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnProbability>.NativeClassPtr, 100667075);
			SpawnProbability.NativeMethodInfoPtr_PickOne_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnProbability>.NativeClassPtr, 100667076);
			SpawnProbability.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnProbability>.NativeClassPtr, 100667077);
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x000B934C File Offset: 0x000B754C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84168, XrefRangeEnd = 84191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnProbability.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x000B9380 File Offset: 0x000B7580
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84219, RefRangeEnd = 84221, XrefRangeStart = 84191, XrefRangeEnd = 84219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PickOne()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnProbability.NativeMethodInfoPtr_PickOne_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000B93B4 File Offset: 0x000B75B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84221, XrefRangeEnd = 84224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpawnProbability()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnProbability>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnProbability.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x00021371 File Offset: 0x0001F571
		public SpawnProbability(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06003045 RID: 12357 RVA: 0x000B93F0 File Offset: 0x000B75F0
		// (set) Token: 0x06003046 RID: 12358 RVA: 0x0002137A File Offset: 0x0001F57A
		public unsafe float odds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnProbability.NativeFieldInfoPtr_odds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnProbability.NativeFieldInfoPtr_odds)) = value;
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06003047 RID: 12359 RVA: 0x000B9418 File Offset: 0x000B7618
		// (set) Token: 0x06003048 RID: 12360 RVA: 0x00021395 File Offset: 0x0001F595
		public unsafe bool added
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnProbability.NativeFieldInfoPtr_added);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnProbability.NativeFieldInfoPtr_added)) = value;
			}
		}

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeFieldInfoPtr_odds;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeFieldInfoPtr_added;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeMethodInfoPtr_PickOne_Public_Void_0;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
