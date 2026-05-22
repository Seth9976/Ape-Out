using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000B2 RID: 178
	public class PropertyAttribute : Attribute
	{
		// Token: 0x06001168 RID: 4456 RVA: 0x0000A328 File Offset: 0x00008528
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyAttribute()
		{
			Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr);
			PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr, 100664744);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00047F84 File Offset: 0x00046184
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyAttribute.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0000A361 File Offset: 0x00008561
		public PropertyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0000A36A File Offset: 0x0000856A
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0000A377 File Offset: 0x00008577
		public int order
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
