using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003B7 RID: 951
	public class ContextCallbackObject : ContextBoundObject
	{
		// Token: 0x06003EC3 RID: 16067 RVA: 0x00127F44 File Offset: 0x00126144
		// Note: this type is marked as 'beforefieldinit'.
		static ContextCallbackObject()
		{
			Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "ContextCallbackObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr);
			ContextCallbackObject.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr, 100672586);
			ContextCallbackObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr, 100672587);
		}

		// Token: 0x06003EC4 RID: 16068 RVA: 0x00127F9C File Offset: 0x0012619C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCallBack(CrossContextDelegate deleg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deleg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextCallbackObject.NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x00127FE0 File Offset: 0x001261E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextCallbackObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextCallbackObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextCallbackObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x000176A7 File Offset: 0x000158A7
		public ContextCallbackObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040033DB RID: 13275
		private static readonly IntPtr NativeMethodInfoPtr_DoCallBack_Public_Void_CrossContextDelegate_0;

		// Token: 0x040033DC RID: 13276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
