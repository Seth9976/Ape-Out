using System;
using Il2CppCodeStage.AntiCheat.ObscuredTypes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Il2Cpp
{
	// Token: 0x02000139 RID: 313
	public class MySave : MonoBehaviour
	{
		// Token: 0x0600266B RID: 9835 RVA: 0x0009EF58 File Offset: 0x0009D158
		// Note: this type is marked as 'beforefieldinit'.
		static MySave()
		{
			Il2CppClassPointerStore<MySave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MySave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MySave>.NativeClassPtr);
			MySave.NativeFieldInfoPtr_me = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave>.NativeClassPtr, "me");
			MySave.NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave>.NativeClassPtr, "dict");
			MySave.NativeFieldInfoPtr_dictDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave>.NativeClassPtr, "dictDirty");
			MySave.NativeFieldInfoPtr_dirtyTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave>.NativeClassPtr, "dirtyTimer");
			MySave.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave>.NativeClassPtr, "path");
			MySave.NativeFieldInfoPtr_pathTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave>.NativeClassPtr, "pathTemp");
			MySave.NativeFieldInfoPtr_pathOld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave>.NativeClassPtr, "pathOld");
			MySave.NativeFieldInfoPtr_pathOlder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave>.NativeClassPtr, "pathOlder");
			MySave.NativeFieldInfoPtr_writing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave>.NativeClassPtr, "writing");
			MySave.NativeFieldInfoPtr_WritingTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave>.NativeClassPtr, "WritingTask");
			MySave.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666358);
			MySave.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666359);
			MySave.NativeMethodInfoPtr_ReallyWriteIt_Public_Task_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666360);
			MySave.NativeMethodInfoPtr_WriteTheFile_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666361);
			MySave.NativeMethodInfoPtr_SetFloat_Public_Void_String_ObscuredFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666362);
			MySave.NativeMethodInfoPtr_GetFloat_Public_ObscuredFloat_String_ObscuredFloat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666363);
			MySave.NativeMethodInfoPtr_SetInt_Public_Void_String_ObscuredInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666364);
			MySave.NativeMethodInfoPtr_GetInt_Public_ObscuredInt_String_ObscuredInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666365);
			MySave.NativeMethodInfoPtr_WriteDict_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666366);
			MySave.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666367);
			MySave.NativeMethodInfoPtr_EmergencyWrite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666368);
			MySave.NativeMethodInfoPtr_LevelWasLoaded_Public_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666369);
			MySave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave>.NativeClassPtr, 100666370);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x0009F154 File Offset: 0x0009D354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74572, XrefRangeEnd = 74660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x0009F188 File Offset: 0x0009D388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74660, XrefRangeEnd = 74663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x0009F1BC File Offset: 0x0009D3BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74673, RefRangeEnd = 74675, XrefRangeStart = 74663, XrefRangeEnd = 74673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> ReallyWriteIt(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_ReallyWriteIt_Public_Task_1_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x0009F20C File Offset: 0x0009D40C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74679, RefRangeEnd = 74680, XrefRangeStart = 74675, XrefRangeEnd = 74679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteTheFile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_WriteTheFile_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x0009F240 File Offset: 0x0009D440
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 74691, RefRangeEnd = 74698, XrefRangeStart = 74680, XrefRangeEnd = 74691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFloat(string key, ObscuredFloat num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_SetFloat_Public_Void_String_ObscuredFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x0009F290 File Offset: 0x0009D490
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 74712, RefRangeEnd = 74717, XrefRangeStart = 74698, XrefRangeEnd = 74712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredFloat GetFloat(string key, ObscuredFloat defNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_GetFloat_Public_ObscuredFloat_String_ObscuredFloat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x0009F2EC File Offset: 0x0009D4EC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 74728, RefRangeEnd = 74755, XrefRangeStart = 74717, XrefRangeEnd = 74728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInt(string key, ObscuredInt num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_SetInt_Public_Void_String_ObscuredInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x0009F33C File Offset: 0x0009D53C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 74775, RefRangeEnd = 74798, XrefRangeStart = 74755, XrefRangeEnd = 74775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObscuredInt GetInt(string key, ObscuredInt defNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_GetInt_Public_ObscuredInt_String_ObscuredInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x0009F398 File Offset: 0x0009D598
		[CallerCount(0)]
		public unsafe void WriteDict()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_WriteDict_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x0009F3CC File Offset: 0x0009D5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74798, XrefRangeEnd = 74802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x0009F400 File Offset: 0x0009D600
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 74806, RefRangeEnd = 74812, XrefRangeStart = 74802, XrefRangeEnd = 74806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmergencyWrite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_EmergencyWrite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x0009F434 File Offset: 0x0009D634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74812, XrefRangeEnd = 74813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LevelWasLoaded(Scene scen, LoadSceneMode mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scen;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr_LevelWasLoaded_Public_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x0009F480 File Offset: 0x0009D680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MySave()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MySave>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002679 RID: 9849 RVA: 0x0001AD24 File Offset: 0x00018F24
		public MySave(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x0600267A RID: 9850 RVA: 0x0009F4BC File Offset: 0x0009D6BC
		// (set) Token: 0x0600267B RID: 9851 RVA: 0x0001AD2D File Offset: 0x00018F2D
		public unsafe static MySave me
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MySave.NativeFieldInfoPtr_me, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MySave>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MySave.NativeFieldInfoPtr_me, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x0600267C RID: 9852 RVA: 0x0009F4E4 File Offset: 0x0009D6E4
		// (set) Token: 0x0600267D RID: 9853 RVA: 0x0001AD3F File Offset: 0x00018F3F
		public unsafe SaveDict dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave.NativeFieldInfoPtr_dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveDict>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave.NativeFieldInfoPtr_dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x0600267E RID: 9854 RVA: 0x0009F514 File Offset: 0x0009D714
		// (set) Token: 0x0600267F RID: 9855 RVA: 0x0001AD5E File Offset: 0x00018F5E
		public unsafe bool dictDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave.NativeFieldInfoPtr_dictDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave.NativeFieldInfoPtr_dictDirty)) = value;
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06002680 RID: 9856 RVA: 0x0009F53C File Offset: 0x0009D73C
		// (set) Token: 0x06002681 RID: 9857 RVA: 0x0001AD79 File Offset: 0x00018F79
		public unsafe float dirtyTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave.NativeFieldInfoPtr_dirtyTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave.NativeFieldInfoPtr_dirtyTimer)) = value;
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06002682 RID: 9858 RVA: 0x0009F564 File Offset: 0x0009D764
		// (set) Token: 0x06002683 RID: 9859 RVA: 0x0001AD94 File Offset: 0x00018F94
		public unsafe static string path
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MySave.NativeFieldInfoPtr_path, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MySave.NativeFieldInfoPtr_path, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x0009F584 File Offset: 0x0009D784
		// (set) Token: 0x06002685 RID: 9861 RVA: 0x0001ADA6 File Offset: 0x00018FA6
		public unsafe static string pathTemp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MySave.NativeFieldInfoPtr_pathTemp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MySave.NativeFieldInfoPtr_pathTemp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x0009F5A4 File Offset: 0x0009D7A4
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		public unsafe static string pathOld
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MySave.NativeFieldInfoPtr_pathOld, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MySave.NativeFieldInfoPtr_pathOld, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x0009F5C4 File Offset: 0x0009D7C4
		// (set) Token: 0x06002689 RID: 9865 RVA: 0x0001ADCA File Offset: 0x00018FCA
		public unsafe static string pathOlder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MySave.NativeFieldInfoPtr_pathOlder, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MySave.NativeFieldInfoPtr_pathOlder, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x0009F5E4 File Offset: 0x0009D7E4
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x0001ADDC File Offset: 0x00018FDC
		public unsafe bool writing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave.NativeFieldInfoPtr_writing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave.NativeFieldInfoPtr_writing)) = value;
			}
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x0009F60C File Offset: 0x0009D80C
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x0001ADF7 File Offset: 0x00018FF7
		public unsafe Task<bool> WritingTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave.NativeFieldInfoPtr_WritingTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave.NativeFieldInfoPtr_WritingTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeFieldInfoPtr_me;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeFieldInfoPtr_dict;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeFieldInfoPtr_dictDirty;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeFieldInfoPtr_dirtyTimer;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeFieldInfoPtr_path;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeFieldInfoPtr_pathTemp;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeFieldInfoPtr_pathOld;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeFieldInfoPtr_pathOlder;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeFieldInfoPtr_writing;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeFieldInfoPtr_WritingTask;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_ReallyWriteIt_Public_Task_1_Boolean_String_0;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_WriteTheFile_Public_Void_0;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_ObscuredFloat_0;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_ObscuredFloat_String_ObscuredFloat_0;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_SetInt_Public_Void_String_ObscuredInt_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_ObscuredInt_String_ObscuredInt_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_WriteDict_Private_Void_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_EmergencyWrite_Public_Void_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_LevelWasLoaded_Public_Void_Scene_LoadSceneMode_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000334 RID: 820
		[ObfuscatedName("MySave+<ReallyWriteIt>d__11")]
		public sealed class _ReallyWriteIt_d__11 : ValueType
		{
			// Token: 0x060051B9 RID: 20921 RVA: 0x00129A20 File Offset: 0x00127C20
			// Note: this type is marked as 'beforefieldinit'.
			static _ReallyWriteIt_d__11()
			{
				Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MySave>.NativeClassPtr, "<ReallyWriteIt>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr);
				MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr, "<>1__state");
				MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr, "<>t__builder");
				MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr, "<>4__this");
				MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr_json = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr, "json");
				MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr__memoryStream_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr, "<memoryStream>5__2");
				MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr__destStream_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr, "<destStream>5__3");
				MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr, "<>7__wrap3");
				MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr, "<>u__1");
				MySave._ReallyWriteIt_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr, 100666371);
				MySave._ReallyWriteIt_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr, 100666372);
			}

			// Token: 0x060051BA RID: 20922 RVA: 0x00129B14 File Offset: 0x00127D14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74445, XrefRangeEnd = 74504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave._ReallyWriteIt_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051BB RID: 20923 RVA: 0x00129B4C File Offset: 0x00127D4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74504, XrefRangeEnd = 74519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave._ReallyWriteIt_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051BC RID: 20924 RVA: 0x0002F93D File Offset: 0x0002DB3D
			public _ReallyWriteIt_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060051BD RID: 20925 RVA: 0x0002F946 File Offset: 0x0002DB46
			public _ReallyWriteIt_d__11()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MySave._ReallyWriteIt_d__11>.NativeClassPtr))
			{
			}

			// Token: 0x17001DCC RID: 7628
			// (get) Token: 0x060051BE RID: 20926 RVA: 0x00129B94 File Offset: 0x00127D94
			// (set) Token: 0x060051BF RID: 20927 RVA: 0x0002F958 File Offset: 0x0002DB58
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DCD RID: 7629
			// (get) Token: 0x060051C0 RID: 20928 RVA: 0x00129BBC File Offset: 0x00127DBC
			// (set) Token: 0x060051C1 RID: 20929 RVA: 0x0002F973 File Offset: 0x0002DB73
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001DCE RID: 7630
			// (get) Token: 0x060051C2 RID: 20930 RVA: 0x00129BEC File Offset: 0x00127DEC
			// (set) Token: 0x060051C3 RID: 20931 RVA: 0x0002F9A1 File Offset: 0x0002DBA1
			public unsafe MySave __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MySave>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DCF RID: 7631
			// (get) Token: 0x060051C4 RID: 20932 RVA: 0x00129C1C File Offset: 0x00127E1C
			// (set) Token: 0x060051C5 RID: 20933 RVA: 0x0002F9C0 File Offset: 0x0002DBC0
			public unsafe string json
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr_json);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr_json), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001DD0 RID: 7632
			// (get) Token: 0x060051C6 RID: 20934 RVA: 0x00129C44 File Offset: 0x00127E44
			// (set) Token: 0x060051C7 RID: 20935 RVA: 0x0002F9DF File Offset: 0x0002DBDF
			public unsafe MemoryStream _memoryStream_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr__memoryStream_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr__memoryStream_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DD1 RID: 7633
			// (get) Token: 0x060051C8 RID: 20936 RVA: 0x00129C74 File Offset: 0x00127E74
			// (set) Token: 0x060051C9 RID: 20937 RVA: 0x0002F9FE File Offset: 0x0002DBFE
			public unsafe FileStream _destStream_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr__destStream_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr__destStream_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DD2 RID: 7634
			// (get) Token: 0x060051CA RID: 20938 RVA: 0x00129CA4 File Offset: 0x00127EA4
			// (set) Token: 0x060051CB RID: 20939 RVA: 0x0002FA1D File Offset: 0x0002DC1D
			public unsafe FileStream __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileStream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DD3 RID: 7635
			// (get) Token: 0x060051CC RID: 20940 RVA: 0x00129CD4 File Offset: 0x00127ED4
			// (set) Token: 0x060051CD RID: 20941 RVA: 0x0002FA3C File Offset: 0x0002DC3C
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._ReallyWriteIt_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04003613 RID: 13843
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003614 RID: 13844
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04003615 RID: 13845
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003616 RID: 13846
			private static readonly IntPtr NativeFieldInfoPtr_json;

			// Token: 0x04003617 RID: 13847
			private static readonly IntPtr NativeFieldInfoPtr__memoryStream_5__2;

			// Token: 0x04003618 RID: 13848
			private static readonly IntPtr NativeFieldInfoPtr__destStream_5__3;

			// Token: 0x04003619 RID: 13849
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400361A RID: 13850
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400361B RID: 13851
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400361C RID: 13852
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000335 RID: 821
		[ObfuscatedName("MySave+<WriteTheFile>d__13")]
		public sealed class _WriteTheFile_d__13 : ValueType
		{
			// Token: 0x060051CE RID: 20942 RVA: 0x00129D04 File Offset: 0x00127F04
			// Note: this type is marked as 'beforefieldinit'.
			static _WriteTheFile_d__13()
			{
				Il2CppClassPointerStore<MySave._WriteTheFile_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MySave>.NativeClassPtr, "<WriteTheFile>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MySave._WriteTheFile_d__13>.NativeClassPtr);
				MySave._WriteTheFile_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._WriteTheFile_d__13>.NativeClassPtr, "<>1__state");
				MySave._WriteTheFile_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._WriteTheFile_d__13>.NativeClassPtr, "<>t__builder");
				MySave._WriteTheFile_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._WriteTheFile_d__13>.NativeClassPtr, "<>4__this");
				MySave._WriteTheFile_d__13.NativeFieldInfoPtr__json_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._WriteTheFile_d__13>.NativeClassPtr, "<json>5__2");
				MySave._WriteTheFile_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._WriteTheFile_d__13>.NativeClassPtr, "<>u__1");
				MySave._WriteTheFile_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave._WriteTheFile_d__13>.NativeClassPtr, 100666373);
				MySave._WriteTheFile_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave._WriteTheFile_d__13>.NativeClassPtr, 100666374);
			}

			// Token: 0x060051CF RID: 20943 RVA: 0x00129DBC File Offset: 0x00127FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74519, XrefRangeEnd = 74541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave._WriteTheFile_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051D0 RID: 20944 RVA: 0x00129DF4 File Offset: 0x00127FF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74541, XrefRangeEnd = 74555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave._WriteTheFile_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051D1 RID: 20945 RVA: 0x0002FA6A File Offset: 0x0002DC6A
			public _WriteTheFile_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060051D2 RID: 20946 RVA: 0x0002FA73 File Offset: 0x0002DC73
			public _WriteTheFile_d__13()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MySave._WriteTheFile_d__13>.NativeClassPtr))
			{
			}

			// Token: 0x17001DD4 RID: 7636
			// (get) Token: 0x060051D3 RID: 20947 RVA: 0x00129E3C File Offset: 0x0012803C
			// (set) Token: 0x060051D4 RID: 20948 RVA: 0x0002FA85 File Offset: 0x0002DC85
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._WriteTheFile_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._WriteTheFile_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DD5 RID: 7637
			// (get) Token: 0x060051D5 RID: 20949 RVA: 0x00129E64 File Offset: 0x00128064
			// (set) Token: 0x060051D6 RID: 20950 RVA: 0x0002FAA0 File Offset: 0x0002DCA0
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._WriteTheFile_d__13.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._WriteTheFile_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001DD6 RID: 7638
			// (get) Token: 0x060051D7 RID: 20951 RVA: 0x00129E94 File Offset: 0x00128094
			// (set) Token: 0x060051D8 RID: 20952 RVA: 0x0002FACE File Offset: 0x0002DCCE
			public unsafe MySave __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._WriteTheFile_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MySave>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._WriteTheFile_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DD7 RID: 7639
			// (get) Token: 0x060051D9 RID: 20953 RVA: 0x00129EC4 File Offset: 0x001280C4
			// (set) Token: 0x060051DA RID: 20954 RVA: 0x0002FAED File Offset: 0x0002DCED
			public unsafe string _json_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._WriteTheFile_d__13.NativeFieldInfoPtr__json_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._WriteTheFile_d__13.NativeFieldInfoPtr__json_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001DD8 RID: 7640
			// (get) Token: 0x060051DB RID: 20955 RVA: 0x00129EEC File Offset: 0x001280EC
			// (set) Token: 0x060051DC RID: 20956 RVA: 0x0002FB0C File Offset: 0x0002DD0C
			public TaskAwaiter<bool> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._WriteTheFile_d__13.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._WriteTheFile_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400361D RID: 13853
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400361E RID: 13854
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400361F RID: 13855
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003620 RID: 13856
			private static readonly IntPtr NativeFieldInfoPtr__json_5__2;

			// Token: 0x04003621 RID: 13857
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04003622 RID: 13858
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003623 RID: 13859
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000336 RID: 822
		[ObfuscatedName("MySave+<OnDestroy>d__19")]
		public sealed class _OnDestroy_d__19 : ValueType
		{
			// Token: 0x060051DD RID: 20957 RVA: 0x00129F1C File Offset: 0x0012811C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnDestroy_d__19()
			{
				Il2CppClassPointerStore<MySave._OnDestroy_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MySave>.NativeClassPtr, "<OnDestroy>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MySave._OnDestroy_d__19>.NativeClassPtr);
				MySave._OnDestroy_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._OnDestroy_d__19>.NativeClassPtr, "<>1__state");
				MySave._OnDestroy_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._OnDestroy_d__19>.NativeClassPtr, "<>t__builder");
				MySave._OnDestroy_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._OnDestroy_d__19>.NativeClassPtr, "<>4__this");
				MySave._OnDestroy_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave._OnDestroy_d__19>.NativeClassPtr, 100666375);
				MySave._OnDestroy_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave._OnDestroy_d__19>.NativeClassPtr, 100666376);
			}

			// Token: 0x060051DE RID: 20958 RVA: 0x00129FAC File Offset: 0x001281AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74555, XrefRangeEnd = 74557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave._OnDestroy_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051DF RID: 20959 RVA: 0x00129FE4 File Offset: 0x001281E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave._OnDestroy_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051E0 RID: 20960 RVA: 0x0002FB3A File Offset: 0x0002DD3A
			public _OnDestroy_d__19(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060051E1 RID: 20961 RVA: 0x0002FB43 File Offset: 0x0002DD43
			public _OnDestroy_d__19()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MySave._OnDestroy_d__19>.NativeClassPtr))
			{
			}

			// Token: 0x17001DD9 RID: 7641
			// (get) Token: 0x060051E2 RID: 20962 RVA: 0x0012A02C File Offset: 0x0012822C
			// (set) Token: 0x060051E3 RID: 20963 RVA: 0x0002FB55 File Offset: 0x0002DD55
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._OnDestroy_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._OnDestroy_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DDA RID: 7642
			// (get) Token: 0x060051E4 RID: 20964 RVA: 0x0012A054 File Offset: 0x00128254
			// (set) Token: 0x060051E5 RID: 20965 RVA: 0x0002FB70 File Offset: 0x0002DD70
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._OnDestroy_d__19.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._OnDestroy_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001DDB RID: 7643
			// (get) Token: 0x060051E6 RID: 20966 RVA: 0x0012A084 File Offset: 0x00128284
			// (set) Token: 0x060051E7 RID: 20967 RVA: 0x0002FB9E File Offset: 0x0002DD9E
			public unsafe MySave __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._OnDestroy_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MySave>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._OnDestroy_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003624 RID: 13860
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003625 RID: 13861
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04003626 RID: 13862
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003627 RID: 13863
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003628 RID: 13864
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000337 RID: 823
		[ObfuscatedName("MySave+<EmergencyWrite>d__20")]
		public sealed class _EmergencyWrite_d__20 : ValueType
		{
			// Token: 0x060051E8 RID: 20968 RVA: 0x0012A0B4 File Offset: 0x001282B4
			// Note: this type is marked as 'beforefieldinit'.
			static _EmergencyWrite_d__20()
			{
				Il2CppClassPointerStore<MySave._EmergencyWrite_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MySave>.NativeClassPtr, "<EmergencyWrite>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MySave._EmergencyWrite_d__20>.NativeClassPtr);
				MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._EmergencyWrite_d__20>.NativeClassPtr, "<>1__state");
				MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._EmergencyWrite_d__20>.NativeClassPtr, "<>t__builder");
				MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._EmergencyWrite_d__20>.NativeClassPtr, "<>4__this");
				MySave._EmergencyWrite_d__20.NativeFieldInfoPtr__json_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._EmergencyWrite_d__20>.NativeClassPtr, "<json>5__2");
				MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MySave._EmergencyWrite_d__20>.NativeClassPtr, "<>u__1");
				MySave._EmergencyWrite_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave._EmergencyWrite_d__20>.NativeClassPtr, 100666377);
				MySave._EmergencyWrite_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MySave._EmergencyWrite_d__20>.NativeClassPtr, 100666378);
			}

			// Token: 0x060051E9 RID: 20969 RVA: 0x0012A16C File Offset: 0x0012836C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74557, XrefRangeEnd = 74572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave._EmergencyWrite_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060051EA RID: 20970 RVA: 0x0012A1A4 File Offset: 0x001283A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MySave._EmergencyWrite_d__20.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060051EB RID: 20971 RVA: 0x0002FBBD File Offset: 0x0002DDBD
			public _EmergencyWrite_d__20(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060051EC RID: 20972 RVA: 0x0002FBC6 File Offset: 0x0002DDC6
			public _EmergencyWrite_d__20()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MySave._EmergencyWrite_d__20>.NativeClassPtr))
			{
			}

			// Token: 0x17001DDC RID: 7644
			// (get) Token: 0x060051ED RID: 20973 RVA: 0x0012A1EC File Offset: 0x001283EC
			// (set) Token: 0x060051EE RID: 20974 RVA: 0x0002FBD8 File Offset: 0x0002DDD8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001DDD RID: 7645
			// (get) Token: 0x060051EF RID: 20975 RVA: 0x0012A214 File Offset: 0x00128414
			// (set) Token: 0x060051F0 RID: 20976 RVA: 0x0002FBF3 File Offset: 0x0002DDF3
			public AsyncVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___t__builder);
					return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001DDE RID: 7646
			// (get) Token: 0x060051F1 RID: 20977 RVA: 0x0012A244 File Offset: 0x00128444
			// (set) Token: 0x060051F2 RID: 20978 RVA: 0x0002FC21 File Offset: 0x0002DE21
			public unsafe MySave __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MySave>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001DDF RID: 7647
			// (get) Token: 0x060051F3 RID: 20979 RVA: 0x0012A274 File Offset: 0x00128474
			// (set) Token: 0x060051F4 RID: 20980 RVA: 0x0002FC40 File Offset: 0x0002DE40
			public unsafe string _json_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._EmergencyWrite_d__20.NativeFieldInfoPtr__json_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._EmergencyWrite_d__20.NativeFieldInfoPtr__json_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17001DE0 RID: 7648
			// (get) Token: 0x060051F5 RID: 20981 RVA: 0x0012A29C File Offset: 0x0012849C
			// (set) Token: 0x060051F6 RID: 20982 RVA: 0x0002FC5F File Offset: 0x0002DE5F
			public TaskAwaiter<bool> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MySave._EmergencyWrite_d__20.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04003629 RID: 13865
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400362A RID: 13866
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400362B RID: 13867
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400362C RID: 13868
			private static readonly IntPtr NativeFieldInfoPtr__json_5__2;

			// Token: 0x0400362D RID: 13869
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400362E RID: 13870
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400362F RID: 13871
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
