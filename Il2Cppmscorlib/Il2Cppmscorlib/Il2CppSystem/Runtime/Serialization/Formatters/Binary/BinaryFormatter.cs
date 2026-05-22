using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000377 RID: 887
	public sealed class BinaryFormatter : Object
	{
		// Token: 0x0600391A RID: 14618 RVA: 0x00113AB0 File Offset: 0x00111CB0
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryFormatter()
		{
			Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr);
			BinaryFormatter.NativeFieldInfoPtr_m_surrogates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_surrogates");
			BinaryFormatter.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_context");
			BinaryFormatter.NativeFieldInfoPtr_m_binder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_binder");
			BinaryFormatter.NativeFieldInfoPtr_m_typeFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_typeFormat");
			BinaryFormatter.NativeFieldInfoPtr_m_assemblyFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_assemblyFormat");
			BinaryFormatter.NativeFieldInfoPtr_m_securityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_securityLevel");
			BinaryFormatter.NativeFieldInfoPtr_m_crossAppDomainArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "m_crossAppDomainArray");
			BinaryFormatter.NativeFieldInfoPtr_typeNameCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, "typeNameCache");
			BinaryFormatter.NativeMethodInfoPtr_set_AssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671985);
			BinaryFormatter.NativeMethodInfoPtr_set_SurrogateSelector_Public_Virtual_Final_New_set_Void_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671986);
			BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671987);
			BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_ISurrogateSelector_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671988);
			BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671989);
			BinaryFormatter.NativeMethodInfoPtr_Deserialize_Internal_Object_Stream_HeaderHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671990);
			BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_HeaderHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671991);
			BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671992);
			BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_Il2CppReferenceArray_1_Header_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671993);
			BinaryFormatter.NativeMethodInfoPtr_Serialize_Internal_Void_Stream_Object_Il2CppReferenceArray_1_Header_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671994);
			BinaryFormatter.NativeMethodInfoPtr_GetTypeInformation_Internal_Static_TypeInformation_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr, 100671995);
		}

		// Token: 0x17000DFA RID: 3578
		// (set) Token: 0x0600391B RID: 14619 RVA: 0x00113C5C File Offset: 0x00111E5C
		public unsafe FormatterAssemblyStyle AssemblyFormat
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_set_AssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (set) Token: 0x0600391C RID: 14620 RVA: 0x00113C9C File Offset: 0x00111E9C
		public unsafe ISurrogateSelector SurrogateSelector
		{
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 14237, RefRangeEnd = 14316, XrefRangeStart = 14237, XrefRangeEnd = 14316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_set_SurrogateSelector_Public_Virtual_Final_New_set_Void_ISurrogateSelector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x00113CE0 File Offset: 0x00111EE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 216349, RefRangeEnd = 216356, XrefRangeStart = 216349, XrefRangeEnd = 216349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryFormatter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x00113D1C File Offset: 0x00111F1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 216356, RefRangeEnd = 216358, XrefRangeStart = 216356, XrefRangeEnd = 216356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BinaryFormatter(ISurrogateSelector selector, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BinaryFormatter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr__ctor_Public_Void_ISurrogateSelector_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x00113D80 File Offset: 0x00111F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216358, XrefRangeEnd = 216359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(Stream serializationStream)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x00113DD0 File Offset: 0x00111FD0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 216392, RefRangeEnd = 216398, XrefRangeStart = 216359, XrefRangeEnd = 216392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Deserialize_Internal_Object_Stream_HeaderHandler_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x00113E40 File Offset: 0x00112040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216398, XrefRangeEnd = 216399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Deserialize(Stream serializationStream, HeaderHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_HeaderHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x00113EA4 File Offset: 0x001120A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216399, XrefRangeEnd = 216400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Stream serializationStream, Object graph)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graph);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x00113EF8 File Offset: 0x001120F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216400, XrefRangeEnd = 216401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Stream serializationStream, Object graph, Il2CppReferenceArray<Header> headers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graph);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_Il2CppReferenceArray_1_Header_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x00113F60 File Offset: 0x00112160
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 216417, RefRangeEnd = 216426, XrefRangeStart = 216401, XrefRangeEnd = 216417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Serialize(Stream serializationStream, Object graph, Il2CppReferenceArray<Header> headers, bool fCheck)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graph);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(headers);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_Serialize_Internal_Void_Stream_Object_Il2CppReferenceArray_1_Header_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x00113FD4 File Offset: 0x001121D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 216452, RefRangeEnd = 216456, XrefRangeStart = 216426, XrefRangeEnd = 216452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeInformation GetTypeInformation(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryFormatter.NativeMethodInfoPtr_GetTypeInformation_Internal_Static_TypeInformation_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInformation>(intPtr3) : null;
			}
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x00014A4F File Offset: 0x00012C4F
		public BinaryFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x00114018 File Offset: 0x00112218
		// (set) Token: 0x06003928 RID: 14632 RVA: 0x00014A58 File Offset: 0x00012C58
		public unsafe ISurrogateSelector m_surrogates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_surrogates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISurrogateSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_surrogates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x00114048 File Offset: 0x00112248
		// (set) Token: 0x0600392A RID: 14634 RVA: 0x00014A77 File Offset: 0x00012C77
		public StreamingContext m_context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_context);
				return new StreamingContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_context), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StreamingContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x00114078 File Offset: 0x00112278
		// (set) Token: 0x0600392C RID: 14636 RVA: 0x00014AA5 File Offset: 0x00012CA5
		public unsafe SerializationBinder m_binder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_binder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationBinder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_binder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x0600392D RID: 14637 RVA: 0x001140A8 File Offset: 0x001122A8
		// (set) Token: 0x0600392E RID: 14638 RVA: 0x00014AC4 File Offset: 0x00012CC4
		public unsafe FormatterTypeStyle m_typeFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_typeFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_typeFormat)) = value;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x001140D0 File Offset: 0x001122D0
		// (set) Token: 0x06003930 RID: 14640 RVA: 0x00014ADF File Offset: 0x00012CDF
		public unsafe FormatterAssemblyStyle m_assemblyFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_assemblyFormat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_assemblyFormat)) = value;
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x001140F8 File Offset: 0x001122F8
		// (set) Token: 0x06003932 RID: 14642 RVA: 0x00014AFA File Offset: 0x00012CFA
		public unsafe TypeFilterLevel m_securityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_securityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_securityLevel)) = value;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x00114120 File Offset: 0x00112320
		// (set) Token: 0x06003934 RID: 14644 RVA: 0x00014B15 File Offset: 0x00012D15
		public unsafe Il2CppReferenceArray<Object> m_crossAppDomainArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_crossAppDomainArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BinaryFormatter.NativeFieldInfoPtr_m_crossAppDomainArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x00114150 File Offset: 0x00112350
		// (set) Token: 0x06003936 RID: 14646 RVA: 0x00014B34 File Offset: 0x00012D34
		public unsafe static Dictionary<Type, TypeInformation> typeNameCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BinaryFormatter.NativeFieldInfoPtr_typeNameCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Type, TypeInformation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BinaryFormatter.NativeFieldInfoPtr_typeNameCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400301B RID: 12315
		private static readonly IntPtr NativeFieldInfoPtr_m_surrogates;

		// Token: 0x0400301C RID: 12316
		private static readonly IntPtr NativeFieldInfoPtr_m_context;

		// Token: 0x0400301D RID: 12317
		private static readonly IntPtr NativeFieldInfoPtr_m_binder;

		// Token: 0x0400301E RID: 12318
		private static readonly IntPtr NativeFieldInfoPtr_m_typeFormat;

		// Token: 0x0400301F RID: 12319
		private static readonly IntPtr NativeFieldInfoPtr_m_assemblyFormat;

		// Token: 0x04003020 RID: 12320
		private static readonly IntPtr NativeFieldInfoPtr_m_securityLevel;

		// Token: 0x04003021 RID: 12321
		private static readonly IntPtr NativeFieldInfoPtr_m_crossAppDomainArray;

		// Token: 0x04003022 RID: 12322
		private static readonly IntPtr NativeFieldInfoPtr_typeNameCache;

		// Token: 0x04003023 RID: 12323
		private static readonly IntPtr NativeMethodInfoPtr_set_AssemblyFormat_Public_set_Void_FormatterAssemblyStyle_0;

		// Token: 0x04003024 RID: 12324
		private static readonly IntPtr NativeMethodInfoPtr_set_SurrogateSelector_Public_Virtual_Final_New_set_Void_ISurrogateSelector_0;

		// Token: 0x04003025 RID: 12325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003026 RID: 12326
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISurrogateSelector_StreamingContext_0;

		// Token: 0x04003027 RID: 12327
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_0;

		// Token: 0x04003028 RID: 12328
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Internal_Object_Stream_HeaderHandler_Boolean_0;

		// Token: 0x04003029 RID: 12329
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Object_Stream_HeaderHandler_0;

		// Token: 0x0400302A RID: 12330
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_0;

		// Token: 0x0400302B RID: 12331
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_Stream_Object_Il2CppReferenceArray_1_Header_0;

		// Token: 0x0400302C RID: 12332
		private static readonly IntPtr NativeMethodInfoPtr_Serialize_Internal_Void_Stream_Object_Il2CppReferenceArray_1_Header_Boolean_0;

		// Token: 0x0400302D RID: 12333
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeInformation_Internal_Static_TypeInformation_Type_0;
	}
}
