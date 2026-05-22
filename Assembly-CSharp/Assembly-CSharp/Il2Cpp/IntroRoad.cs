using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000112 RID: 274
	public class IntroRoad : MonoBehaviour
	{
		// Token: 0x06002084 RID: 8324 RVA: 0x0008F3F4 File Offset: 0x0008D5F4
		// Note: this type is marked as 'beforefieldinit'.
		static IntroRoad()
		{
			Il2CppClassPointerStore<IntroRoad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IntroRoad");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntroRoad>.NativeClassPtr);
			IntroRoad.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroRoad>.NativeClassPtr, "length");
			IntroRoad.NativeFieldInfoPtr_moved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroRoad>.NativeClassPtr, "moved");
			IntroRoad.NativeFieldInfoPtr_startx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntroRoad>.NativeClassPtr, "startx");
			IntroRoad.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroRoad>.NativeClassPtr, 100665861);
			IntroRoad.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntroRoad>.NativeClassPtr, 100665862);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x0008F488 File Offset: 0x0008D688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67767, XrefRangeEnd = 67785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroRoad.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x0008F4BC File Offset: 0x0008D6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntroRoad()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntroRoad>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntroRoad.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x00016BDB File Offset: 0x00014DDB
		public IntroRoad(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002088 RID: 8328 RVA: 0x0008F4F8 File Offset: 0x0008D6F8
		// (set) Token: 0x06002089 RID: 8329 RVA: 0x00016BE4 File Offset: 0x00014DE4
		public unsafe float length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroRoad.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroRoad.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0008F520 File Offset: 0x0008D720
		// (set) Token: 0x0600208B RID: 8331 RVA: 0x00016BFF File Offset: 0x00014DFF
		public unsafe float moved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroRoad.NativeFieldInfoPtr_moved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroRoad.NativeFieldInfoPtr_moved)) = value;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x0008F548 File Offset: 0x0008D748
		// (set) Token: 0x0600208D RID: 8333 RVA: 0x00016C1A File Offset: 0x00014E1A
		public unsafe float startx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroRoad.NativeFieldInfoPtr_startx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntroRoad.NativeFieldInfoPtr_startx)) = value;
			}
		}

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeFieldInfoPtr_moved;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeFieldInfoPtr_startx;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
