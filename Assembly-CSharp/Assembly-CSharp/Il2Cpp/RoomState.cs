using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000175 RID: 373
	public class RoomState : MonoBehaviour
	{
		// Token: 0x06002CDC RID: 11484 RVA: 0x000AFF4C File Offset: 0x000AE14C
		// Note: this type is marked as 'beforefieldinit'.
		static RoomState()
		{
			Il2CppClassPointerStore<RoomState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RoomState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoomState>.NativeClassPtr);
			RoomState.NativeFieldInfoPtr_tL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomState>.NativeClassPtr, "tL");
			RoomState.NativeFieldInfoPtr_tR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomState>.NativeClassPtr, "tR");
			RoomState.NativeFieldInfoPtr_bR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomState>.NativeClassPtr, "bR");
			RoomState.NativeFieldInfoPtr_bL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomState>.NativeClassPtr, "bL");
			RoomState.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomState>.NativeClassPtr, "height");
			RoomState.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoomState>.NativeClassPtr, "width");
			RoomState.NativeMethodInfoPtr_MyAwake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomState>.NativeClassPtr, 100666784);
			RoomState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoomState>.NativeClassPtr, 100666785);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x000B001C File Offset: 0x000AE21C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80792, RefRangeEnd = 80794, XrefRangeStart = 80790, XrefRangeEnd = 80792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MyAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoomState.NativeMethodInfoPtr_MyAwake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x000B0050 File Offset: 0x000AE250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoomState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoomState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoomState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x0001F1F2 File Offset: 0x0001D3F2
		public RoomState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06002CE0 RID: 11488 RVA: 0x000B008C File Offset: 0x000AE28C
		// (set) Token: 0x06002CE1 RID: 11489 RVA: 0x0001F1FB File Offset: 0x0001D3FB
		public unsafe Vector2 tL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_tL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_tL)) = value;
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000B00B4 File Offset: 0x000AE2B4
		// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x0001F216 File Offset: 0x0001D416
		public unsafe Vector2 tR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_tR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_tR)) = value;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x000B00DC File Offset: 0x000AE2DC
		// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x0001F231 File Offset: 0x0001D431
		public unsafe Vector2 bR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_bR);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_bR)) = value;
			}
		}

		// Token: 0x17001027 RID: 4135
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x000B0104 File Offset: 0x000AE304
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x0001F24C File Offset: 0x0001D44C
		public unsafe Vector2 bL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_bL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_bL)) = value;
			}
		}

		// Token: 0x17001028 RID: 4136
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x000B012C File Offset: 0x000AE32C
		// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x0001F267 File Offset: 0x0001D467
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x17001029 RID: 4137
		// (get) Token: 0x06002CEA RID: 11498 RVA: 0x000B0154 File Offset: 0x000AE354
		// (set) Token: 0x06002CEB RID: 11499 RVA: 0x0001F282 File Offset: 0x0001D482
		public unsafe float width
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_width);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoomState.NativeFieldInfoPtr_width)) = value;
			}
		}

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeFieldInfoPtr_tL;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeFieldInfoPtr_tR;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeFieldInfoPtr_bR;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeFieldInfoPtr_bL;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeFieldInfoPtr_width;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeMethodInfoPtr_MyAwake_Public_Void_0;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
