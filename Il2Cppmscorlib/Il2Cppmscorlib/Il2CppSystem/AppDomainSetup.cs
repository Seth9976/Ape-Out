using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200010C RID: 268
	[Serializable]
	public sealed class AppDomainSetup : Object
	{
		// Token: 0x060013E1 RID: 5089 RVA: 0x00080174 File Offset: 0x0007E374
		// Note: this type is marked as 'beforefieldinit'.
		static AppDomainSetup()
		{
			Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppDomainSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr);
			AppDomainSetup.NativeFieldInfoPtr_application_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_base");
			AppDomainSetup.NativeFieldInfoPtr_application_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_name");
			AppDomainSetup.NativeFieldInfoPtr_cache_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "cache_path");
			AppDomainSetup.NativeFieldInfoPtr_configuration_file = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "configuration_file");
			AppDomainSetup.NativeFieldInfoPtr_dynamic_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "dynamic_base");
			AppDomainSetup.NativeFieldInfoPtr_license_file = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "license_file");
			AppDomainSetup.NativeFieldInfoPtr_private_bin_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "private_bin_path");
			AppDomainSetup.NativeFieldInfoPtr_private_bin_path_probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "private_bin_path_probe");
			AppDomainSetup.NativeFieldInfoPtr_shadow_copy_directories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "shadow_copy_directories");
			AppDomainSetup.NativeFieldInfoPtr_shadow_copy_files = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "shadow_copy_files");
			AppDomainSetup.NativeFieldInfoPtr_publisher_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "publisher_policy");
			AppDomainSetup.NativeFieldInfoPtr_path_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "path_changed");
			AppDomainSetup.NativeFieldInfoPtr_loader_optimization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "loader_optimization");
			AppDomainSetup.NativeFieldInfoPtr_disallow_binding_redirects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_binding_redirects");
			AppDomainSetup.NativeFieldInfoPtr_disallow_code_downloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_code_downloads");
			AppDomainSetup.NativeFieldInfoPtr__activationArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "_activationArguments");
			AppDomainSetup.NativeFieldInfoPtr_domain_initializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "domain_initializer");
			AppDomainSetup.NativeFieldInfoPtr_application_trust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_trust");
			AppDomainSetup.NativeFieldInfoPtr_domain_initializer_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "domain_initializer_args");
			AppDomainSetup.NativeFieldInfoPtr_disallow_appbase_probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_appbase_probe");
			AppDomainSetup.NativeFieldInfoPtr_configuration_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "configuration_bytes");
			AppDomainSetup.NativeFieldInfoPtr_serialized_non_primitives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "serialized_non_primitives");
			AppDomainSetup.NativeFieldInfoPtr__TargetFrameworkName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "<TargetFrameworkName>k__BackingField");
			AppDomainSetup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, 100666793);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x00080384 File Offset: 0x0007E584
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppDomainSetup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppDomainSetup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x00006BB6 File Offset: 0x00004DB6
		public AppDomainSetup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x000803C0 File Offset: 0x0007E5C0
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x00006BBF File Offset: 0x00004DBF
		public unsafe string application_base
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_base);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_base), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x000803E8 File Offset: 0x0007E5E8
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x00006BDE File Offset: 0x00004DDE
		public unsafe string application_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00080410 File Offset: 0x0007E610
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x00006BFD File Offset: 0x00004DFD
		public unsafe string cache_path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_cache_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_cache_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x00080438 File Offset: 0x0007E638
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x00006C1C File Offset: 0x00004E1C
		public unsafe string configuration_file
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_file);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_file), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00080460 File Offset: 0x0007E660
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x00006C3B File Offset: 0x00004E3B
		public unsafe string dynamic_base
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_dynamic_base);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_dynamic_base), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00080488 File Offset: 0x0007E688
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x00006C5A File Offset: 0x00004E5A
		public unsafe string license_file
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_license_file);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_license_file), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x000804B0 File Offset: 0x0007E6B0
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x00006C79 File Offset: 0x00004E79
		public unsafe string private_bin_path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x000804D8 File Offset: 0x0007E6D8
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x00006C98 File Offset: 0x00004E98
		public unsafe string private_bin_path_probe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path_probe);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_private_bin_path_probe), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00080500 File Offset: 0x0007E700
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x00006CB7 File Offset: 0x00004EB7
		public unsafe string shadow_copy_directories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_directories);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_directories), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x00080528 File Offset: 0x0007E728
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00006CD6 File Offset: 0x00004ED6
		public unsafe string shadow_copy_files
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_files);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_shadow_copy_files), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x00080550 File Offset: 0x0007E750
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x00006CF5 File Offset: 0x00004EF5
		public unsafe bool publisher_policy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_publisher_policy);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_publisher_policy)) = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00080578 File Offset: 0x0007E778
		// (set) Token: 0x060013FB RID: 5115 RVA: 0x00006D10 File Offset: 0x00004F10
		public unsafe bool path_changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_path_changed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_path_changed)) = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x000805A0 File Offset: 0x0007E7A0
		// (set) Token: 0x060013FD RID: 5117 RVA: 0x00006D2B File Offset: 0x00004F2B
		public unsafe int loader_optimization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_loader_optimization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_loader_optimization)) = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x000805C8 File Offset: 0x0007E7C8
		// (set) Token: 0x060013FF RID: 5119 RVA: 0x00006D46 File Offset: 0x00004F46
		public unsafe bool disallow_binding_redirects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_binding_redirects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_binding_redirects)) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x000805F0 File Offset: 0x0007E7F0
		// (set) Token: 0x06001401 RID: 5121 RVA: 0x00006D61 File Offset: 0x00004F61
		public unsafe bool disallow_code_downloads
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_code_downloads);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_code_downloads)) = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x00080618 File Offset: 0x0007E818
		// (set) Token: 0x06001403 RID: 5123 RVA: 0x00006D7C File Offset: 0x00004F7C
		public unsafe Object _activationArguments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__activationArguments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__activationArguments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00080648 File Offset: 0x0007E848
		// (set) Token: 0x06001405 RID: 5125 RVA: 0x00006D9B File Offset: 0x00004F9B
		public unsafe Object domain_initializer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x00080678 File Offset: 0x0007E878
		// (set) Token: 0x06001407 RID: 5127 RVA: 0x00006DBA File Offset: 0x00004FBA
		public unsafe Object application_trust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_trust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_application_trust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x000806A8 File Offset: 0x0007E8A8
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x00006DD9 File Offset: 0x00004FD9
		public unsafe Il2CppStringArray domain_initializer_args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer_args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_domain_initializer_args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x000806D8 File Offset: 0x0007E8D8
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x00006DF8 File Offset: 0x00004FF8
		public unsafe bool disallow_appbase_probe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_appbase_probe);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_disallow_appbase_probe)) = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00080700 File Offset: 0x0007E900
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x00006E13 File Offset: 0x00005013
		public unsafe Il2CppStructArray<byte> configuration_bytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_bytes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_configuration_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x00080730 File Offset: 0x0007E930
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x00006E32 File Offset: 0x00005032
		public unsafe Il2CppStructArray<byte> serialized_non_primitives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_serialized_non_primitives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr_serialized_non_primitives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x00080760 File Offset: 0x0007E960
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x00006E51 File Offset: 0x00005051
		public unsafe string _TargetFrameworkName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__TargetFrameworkName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppDomainSetup.NativeFieldInfoPtr__TargetFrameworkName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400112D RID: 4397
		private static readonly IntPtr NativeFieldInfoPtr_application_base;

		// Token: 0x0400112E RID: 4398
		private static readonly IntPtr NativeFieldInfoPtr_application_name;

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeFieldInfoPtr_cache_path;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeFieldInfoPtr_configuration_file;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeFieldInfoPtr_dynamic_base;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeFieldInfoPtr_license_file;

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeFieldInfoPtr_private_bin_path;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeFieldInfoPtr_private_bin_path_probe;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeFieldInfoPtr_shadow_copy_directories;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeFieldInfoPtr_shadow_copy_files;

		// Token: 0x04001137 RID: 4407
		private static readonly IntPtr NativeFieldInfoPtr_publisher_policy;

		// Token: 0x04001138 RID: 4408
		private static readonly IntPtr NativeFieldInfoPtr_path_changed;

		// Token: 0x04001139 RID: 4409
		private static readonly IntPtr NativeFieldInfoPtr_loader_optimization;

		// Token: 0x0400113A RID: 4410
		private static readonly IntPtr NativeFieldInfoPtr_disallow_binding_redirects;

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeFieldInfoPtr_disallow_code_downloads;

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeFieldInfoPtr__activationArguments;

		// Token: 0x0400113D RID: 4413
		private static readonly IntPtr NativeFieldInfoPtr_domain_initializer;

		// Token: 0x0400113E RID: 4414
		private static readonly IntPtr NativeFieldInfoPtr_application_trust;

		// Token: 0x0400113F RID: 4415
		private static readonly IntPtr NativeFieldInfoPtr_domain_initializer_args;

		// Token: 0x04001140 RID: 4416
		private static readonly IntPtr NativeFieldInfoPtr_disallow_appbase_probe;

		// Token: 0x04001141 RID: 4417
		private static readonly IntPtr NativeFieldInfoPtr_configuration_bytes;

		// Token: 0x04001142 RID: 4418
		private static readonly IntPtr NativeFieldInfoPtr_serialized_non_primitives;

		// Token: 0x04001143 RID: 4419
		private static readonly IntPtr NativeFieldInfoPtr__TargetFrameworkName_k__BackingField;

		// Token: 0x04001144 RID: 4420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
