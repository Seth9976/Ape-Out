using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006F RID: 111
	public class BooleanConverter : TypeConverter
	{
		// Token: 0x060007DA RID: 2010 RVA: 0x0002E7F0 File Offset: 0x0002C9F0
		// Note: this type is marked as 'beforefieldinit'.
		static BooleanConverter()
		{
			Il2CppClassPointerStore<BooleanConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "BooleanConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BooleanConverter>.NativeClassPtr);
			BooleanConverter.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanConverter>.NativeClassPtr, "values");
			BooleanConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanConverter>.NativeClassPtr, 100664450);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0002E848 File Offset: 0x0002CA48
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BooleanConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BooleanConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0000516C File Offset: 0x0000336C
		public BooleanConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x0002E884 File Offset: 0x0002CA84
		// (set) Token: 0x060007DE RID: 2014 RVA: 0x00005175 File Offset: 0x00003375
		public unsafe static TypeConverter.StandardValuesCollection values
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BooleanConverter.NativeFieldInfoPtr_values, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeConverter.StandardValuesCollection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BooleanConverter.NativeFieldInfoPtr_values, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
