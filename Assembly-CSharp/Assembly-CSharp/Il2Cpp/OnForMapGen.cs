using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000145 RID: 325
	public class OnForMapGen : MonoBehaviour
	{
		// Token: 0x06002733 RID: 10035 RVA: 0x000A12C4 File Offset: 0x0009F4C4
		// Note: this type is marked as 'beforefieldinit'.
		static OnForMapGen()
		{
			Il2CppClassPointerStore<OnForMapGen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "OnForMapGen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnForMapGen>.NativeClassPtr);
			OnForMapGen.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnForMapGen>.NativeClassPtr, 100666460);
			OnForMapGen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnForMapGen>.NativeClassPtr, 100666461);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000A131C File Offset: 0x0009F51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75529, XrefRangeEnd = 75560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnForMapGen.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000A1350 File Offset: 0x0009F550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnForMapGen()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnForMapGen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnForMapGen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x0001B43F File Offset: 0x0001963F
		public OnForMapGen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001721 RID: 5921
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001722 RID: 5922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
