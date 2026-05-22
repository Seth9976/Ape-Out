using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000097 RID: 151
	public class TypeConverter : Object
	{
		// Token: 0x060008FF RID: 2303 RVA: 0x00031FF0 File Offset: 0x000301F0
		// Note: this type is marked as 'beforefieldinit'.
		static TypeConverter()
		{
			Il2CppClassPointerStore<TypeConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "TypeConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr);
			TypeConverter.NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "s_UseCompatibleTypeConverterBehavior");
			TypeConverter.NativeFieldInfoPtr_useCompatibleTypeConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "useCompatibleTypeConversion");
			TypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, 100664571);
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0003205C File Offset: 0x0003025C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00005A3D File Offset: 0x00003C3D
		public TypeConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00032098 File Offset: 0x00030298
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00005A46 File Offset: 0x00003C46
		public unsafe static string s_UseCompatibleTypeConverterBehavior
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeConverter.NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeConverter.NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x000320B8 File Offset: 0x000302B8
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00005A58 File Offset: 0x00003C58
		public unsafe static bool useCompatibleTypeConversion
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TypeConverter.NativeFieldInfoPtr_useCompatibleTypeConversion, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeConverter.NativeFieldInfoPtr_useCompatibleTypeConversion, (void*)(&value));
			}
		}

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeFieldInfoPtr_s_UseCompatibleTypeConverterBehavior;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeFieldInfoPtr_useCompatibleTypeConversion;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001BC RID: 444
		[DefaultMember("Item")]
		public class StandardValuesCollection : Object
		{
			// Token: 0x0600191B RID: 6427 RVA: 0x0000CF49 File Offset: 0x0000B149
			// Note: this type is marked as 'beforefieldinit'.
			static StandardValuesCollection()
			{
				Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeConverter>.NativeClassPtr, "StandardValuesCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeConverter.StandardValuesCollection>.NativeClassPtr);
			}

			// Token: 0x0600191C RID: 6428 RVA: 0x0000CF69 File Offset: 0x0000B169
			public StandardValuesCollection(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
