using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000032 RID: 50
	public class RandomRotation : MonoBehaviour
	{
		// Token: 0x0600087A RID: 2170 RVA: 0x0004CCB8 File Offset: 0x0004AEB8
		// Note: this type is marked as 'beforefieldinit'.
		static RandomRotation()
		{
			Il2CppClassPointerStore<RandomRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RandomRotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr);
			RandomRotation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, 100663909);
			RandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr, 100663910);
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0004CD10 File Offset: 0x0004AF10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36985, XrefRangeEnd = 36990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomRotation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0004CD44 File Offset: 0x0004AF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RandomRotation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomRotation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RandomRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000079EE File Offset: 0x00005BEE
		public RandomRotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
