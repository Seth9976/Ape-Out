using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x0200001C RID: 28
	public sealed class AsyncReadManagerRequestMetric : ValueType
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00016C18 File Offset: 0x00014E18
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncReadManagerRequestMetric()
		{
			Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", "AsyncReadManagerRequestMetric");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr);
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetName>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<FileName>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<OffsetBytes>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<SizeBytes>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetTypeId>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<CurrentBytesRead>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<BatchReadCount>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<IsBatchRead>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<State>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<ReadType>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<PriorityLevel>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<Subsystem>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<RequestTimeMicroseconds>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TimeInQueueMicroseconds>k__BackingField");
			AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TotalTimeMicroseconds>k__BackingField");
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002619 File Offset: 0x00000819
		public AsyncReadManagerRequestMetric(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002622 File Offset: 0x00000822
		public AsyncReadManagerRequestMetric()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr))
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00016D74 File Offset: 0x00014F74
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002634 File Offset: 0x00000834
		public unsafe string _AssetName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00016D9C File Offset: 0x00014F9C
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002653 File Offset: 0x00000853
		public unsafe string _FileName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00016DC4 File Offset: 0x00014FC4
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002672 File Offset: 0x00000872
		public unsafe ulong _OffsetBytes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00016DEC File Offset: 0x00014FEC
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000268D File Offset: 0x0000088D
		public unsafe ulong _SizeBytes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00016E14 File Offset: 0x00015014
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000026A8 File Offset: 0x000008A8
		public unsafe ulong _AssetTypeId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00016E3C File Offset: 0x0001503C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000026C3 File Offset: 0x000008C3
		public unsafe ulong _CurrentBytesRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField)) = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00016E64 File Offset: 0x00015064
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000026DE File Offset: 0x000008DE
		public unsafe uint _BatchReadCount_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField)) = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00016E8C File Offset: 0x0001508C
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000026F9 File Offset: 0x000008F9
		public unsafe bool _IsBatchRead_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00016EB4 File Offset: 0x000150B4
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00002714 File Offset: 0x00000914
		public unsafe ProcessingState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00016EDC File Offset: 0x000150DC
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000272F File Offset: 0x0000092F
		public unsafe FileReadType _ReadType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00016F04 File Offset: 0x00015104
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000274A File Offset: 0x0000094A
		public unsafe Priority _PriorityLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00016F2C File Offset: 0x0001512C
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002765 File Offset: 0x00000965
		public unsafe AssetLoadingSubsystem _Subsystem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00016F54 File Offset: 0x00015154
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002780 File Offset: 0x00000980
		public unsafe double _RequestTimeMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00016F7C File Offset: 0x0001517C
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000279B File Offset: 0x0000099B
		public unsafe double _TimeInQueueMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00016FA4 File Offset: 0x000151A4
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x000027B6 File Offset: 0x000009B6
		public unsafe double _TotalTimeMicroseconds_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x000027D1 File Offset: 0x000009D1
		public string AssetName
		{
			get
			{
				return this._AssetName_k__BackingField;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000027D9 File Offset: 0x000009D9
		public string FileName
		{
			get
			{
				return this._FileName_k__BackingField;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000027E1 File Offset: 0x000009E1
		public ulong OffsetBytes
		{
			get
			{
				return this._OffsetBytes_k__BackingField;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000027E9 File Offset: 0x000009E9
		public ulong SizeBytes
		{
			get
			{
				return this._SizeBytes_k__BackingField;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000027F1 File Offset: 0x000009F1
		public ulong AssetTypeId
		{
			get
			{
				return this._AssetTypeId_k__BackingField;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000027F9 File Offset: 0x000009F9
		public ulong CurrentBytesRead
		{
			get
			{
				return this._CurrentBytesRead_k__BackingField;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002801 File Offset: 0x00000A01
		public uint BatchReadCount
		{
			get
			{
				return this._BatchReadCount_k__BackingField;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002809 File Offset: 0x00000A09
		public bool IsBatchRead
		{
			get
			{
				return this._IsBatchRead_k__BackingField;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002811 File Offset: 0x00000A11
		public ProcessingState State
		{
			get
			{
				return this._State_k__BackingField;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002819 File Offset: 0x00000A19
		public FileReadType ReadType
		{
			get
			{
				return this._ReadType_k__BackingField;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002821 File Offset: 0x00000A21
		public Priority PriorityLevel
		{
			get
			{
				return this._PriorityLevel_k__BackingField;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002829 File Offset: 0x00000A29
		public AssetLoadingSubsystem Subsystem
		{
			get
			{
				return this._Subsystem_k__BackingField;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002831 File Offset: 0x00000A31
		public double RequestTimeMicroseconds
		{
			get
			{
				return this._RequestTimeMicroseconds_k__BackingField;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002839 File Offset: 0x00000A39
		public double TimeInQueueMicroseconds
		{
			get
			{
				return this._TimeInQueueMicroseconds_k__BackingField;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002841 File Offset: 0x00000A41
		public double TotalTimeMicroseconds
		{
			get
			{
				return this._TotalTimeMicroseconds_k__BackingField;
			}
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr__AssetName_k__BackingField;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr__FileName_k__BackingField;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeFieldInfoPtr__OffsetBytes_k__BackingField;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeFieldInfoPtr__SizeBytes_k__BackingField;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr__AssetTypeId_k__BackingField;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr__CurrentBytesRead_k__BackingField;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr__BatchReadCount_k__BackingField;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr__IsBatchRead_k__BackingField;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr__ReadType_k__BackingField;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr__PriorityLevel_k__BackingField;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeFieldInfoPtr__Subsystem_k__BackingField;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField;
	}
}
