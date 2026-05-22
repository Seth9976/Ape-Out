using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200042D RID: 1069
	[Serializable]
	public sealed class DateTimeConstantAttribute : CustomConstantAttribute
	{
		// Token: 0x0600433D RID: 17213 RVA: 0x00137A88 File Offset: 0x00135C88
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeConstantAttribute()
		{
			Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DateTimeConstantAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr);
			DateTimeConstantAttribute.NativeFieldInfoPtr_date = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr, "date");
			DateTimeConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeConstantAttribute>.NativeClassPtr, 100673131);
		}

		// Token: 0x17001132 RID: 4402
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x00137AE0 File Offset: 0x00135CE0
		public unsafe override Object Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226623, XrefRangeEnd = 226626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeConstantAttribute.NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x00019774 File Offset: 0x00017974
		public DateTimeConstantAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x06004340 RID: 17216 RVA: 0x00137B20 File Offset: 0x00135D20
		// (set) Token: 0x06004341 RID: 17217 RVA: 0x0001977D File Offset: 0x0001797D
		public unsafe DateTime date
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeConstantAttribute.NativeFieldInfoPtr_date);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeConstantAttribute.NativeFieldInfoPtr_date)) = value;
			}
		}

		// Token: 0x040036AF RID: 13999
		private static readonly IntPtr NativeFieldInfoPtr_date;

		// Token: 0x040036B0 RID: 14000
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_Object_0;
	}
}
