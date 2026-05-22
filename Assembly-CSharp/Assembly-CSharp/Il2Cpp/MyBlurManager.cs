using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000136 RID: 310
	public class MyBlurManager : MonoBehaviour
	{
		// Token: 0x06002659 RID: 9817 RVA: 0x0009EC6C File Offset: 0x0009CE6C
		// Note: this type is marked as 'beforefieldinit'.
		static MyBlurManager()
		{
			Il2CppClassPointerStore<MyBlurManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MyBlurManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyBlurManager>.NativeClassPtr);
			MyBlurManager.NativeFieldInfoPtr_iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyBlurManager>.NativeClassPtr, "iterations");
			MyBlurManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyBlurManager>.NativeClassPtr, 100666352);
			MyBlurManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyBlurManager>.NativeClassPtr, 100666353);
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x0009ECD8 File Offset: 0x0009CED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74381, XrefRangeEnd = 74390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyBlurManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x0009ED0C File Offset: 0x0009CF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MyBlurManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyBlurManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MyBlurManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x0001AC84 File Offset: 0x00018E84
		public MyBlurManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x0600265D RID: 9821 RVA: 0x0009ED48 File Offset: 0x0009CF48
		// (set) Token: 0x0600265E RID: 9822 RVA: 0x0001AC8D File Offset: 0x00018E8D
		public unsafe int iterations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyBlurManager.NativeFieldInfoPtr_iterations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MyBlurManager.NativeFieldInfoPtr_iterations)) = value;
			}
		}

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeFieldInfoPtr_iterations;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
