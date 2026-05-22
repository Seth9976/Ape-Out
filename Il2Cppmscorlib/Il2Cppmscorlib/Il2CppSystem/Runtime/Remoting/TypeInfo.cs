using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x020003A4 RID: 932
	[Serializable]
	public class TypeInfo : Object
	{
		// Token: 0x06003DAD RID: 15789 RVA: 0x00123FD4 File Offset: 0x001221D4
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInfo()
		{
			Il2CppClassPointerStore<TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "TypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr);
			TypeInfo.NativeFieldInfoPtr_serverType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, "serverType");
			TypeInfo.NativeFieldInfoPtr_serverHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, "serverHierarchy");
			TypeInfo.NativeFieldInfoPtr_interfacesImplemented = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, "interfacesImplemented");
			TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100672449);
			TypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100672450);
			TypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100672451);
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x0012407C File Offset: 0x0012227C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 221341, RefRangeEnd = 221343, XrefRangeStart = 221304, XrefRangeEnd = 221341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInfo(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x06003DAF RID: 15791 RVA: 0x001240C8 File Offset: 0x001222C8
		public unsafe virtual string TypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x00124100 File Offset: 0x00122300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221343, XrefRangeEnd = 221373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanCastTo(Type fromType, Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003DB1 RID: 15793 RVA: 0x00016FCE File Offset: 0x000151CE
		public TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06003DB2 RID: 15794 RVA: 0x00124160 File Offset: 0x00122360
		// (set) Token: 0x06003DB3 RID: 15795 RVA: 0x00016FD7 File Offset: 0x000151D7
		public unsafe string serverType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06003DB4 RID: 15796 RVA: 0x00124188 File Offset: 0x00122388
		// (set) Token: 0x06003DB5 RID: 15797 RVA: 0x00016FF6 File Offset: 0x000151F6
		public unsafe Il2CppStringArray serverHierarchy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverHierarchy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_serverHierarchy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x06003DB6 RID: 15798 RVA: 0x001241B8 File Offset: 0x001223B8
		// (set) Token: 0x06003DB7 RID: 15799 RVA: 0x00017015 File Offset: 0x00015215
		public unsafe Il2CppStringArray interfacesImplemented
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_interfacesImplemented);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInfo.NativeFieldInfoPtr_interfacesImplemented), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003318 RID: 13080
		private static readonly IntPtr NativeFieldInfoPtr_serverType;

		// Token: 0x04003319 RID: 13081
		private static readonly IntPtr NativeFieldInfoPtr_serverHierarchy;

		// Token: 0x0400331A RID: 13082
		private static readonly IntPtr NativeFieldInfoPtr_interfacesImplemented;

		// Token: 0x0400331B RID: 13083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

		// Token: 0x0400331C RID: 13084
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400331D RID: 13085
		private static readonly IntPtr NativeMethodInfoPtr_CanCastTo_Public_Virtual_Final_New_Boolean_Type_Object_0;
	}
}
